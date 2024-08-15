using Hsrm.DeepModeling.Warehouse.Warehouse;
using Microsoft.CSharp;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using Attribute = NMF.Models.Meta.Attribute;

var stringType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//String");
var recommends = Product.ClassInstance.LookupReference("recommends");

var book = new ProductSpecification
{
    Name = "Book",
    TaxRate = 7,
    Currency = "EUR",
    IntroductionDate = new DateTime(2003, 02, 01),
    Attributes =
    {
        new Attribute { Name = "isbn", LowerBound = 1, Type = stringType }
    }
};

var dvdPlayer = new ProductSpecification
{
    Name = "DVDPlayer",
    TaxRate = 15,
    Currency = "USD"
};

var dvd = new ProductSpecification
{
    Name = "DVD",
    TaxRate = 15,
    Currency = "USD",
    IntroductionDate = new DateTime(2004, 03, 02),
    References =
    {
        new Reference { Name = "recommendedPlayer", Refines = recommends, ReferenceType = dvdPlayer },
    }
};

var mpCase = new ProductSpecification
{
    Name = "MobilePhoneCase",
    TaxRate = 15,
    Currency = "SEK",
    IntroductionDate = new DateTime(2007, 06, 05)
};

var mp = new ProductSpecification
{
    Name = "MobilePhone",
    TaxRate = 15,
    Currency = "SEK",
    IntroductionDate = new DateTime(2006, 05, 04),
    References =
    {
        new Reference { Name = "recommendedCase", Refines = recommends, ReferenceType = mpCase },
    }
};

var aaBatteryCell = new BulkProductSpecification
{
    Name = "AABatteryCell",
    TaxRate = 15,
    Currency = "NZD",
    IntroductionDate = new DateTime(2008, 07, 06)
};

var warehouseNamespace = new Namespace
{
    Name = "MyWarehouse",
    Uri = new Uri("https://example.org"),
    Prefix = "ex",
    Types =
    {
        book,
        dvd,
        dvdPlayer,
        mp,
        mpCase,
        aaBatteryCell
    }
};

var model = new Model { ModelUri = warehouseNamespace.Uri, RootElements = { warehouseNamespace } };

var repository = new ModelRepository();
repository.Save(model, Path.Combine("..", "..", "..", "..", "ProductsGenerator", "products.nmeta"));

var code = MetaFacade.CreateCode(warehouseNamespace, "Hsrm.DeepModeling.Warehouse.Products");
MetaFacade.GenerateCode(code, new CSharpCodeProvider(), Path.Combine("..", "..", "..", "..", "ProductsGenerator", "Metamodel"), true);
