using Hsrm.DeepModeling.Warehouse.Products.MyWarehouse;
using Hsrm.DeepModeling.Warehouse.Warehouse;
using Microsoft.CSharp;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using Attribute = NMF.Models.Meta.Attribute;

var stringType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//String");

var mobyDick = new Book
{
    Name = "Moby Dick",
    SalesPrice = 9.95,
    Isbn = "..."
};

var haChi779 = new DVDPlayer
{
    Name = "HaChi779",
    SalesPrice = 99.99,
    Attributes =
    {
        new Attribute { Name = "serialNumber", LowerBound = 1, Type = stringType }
    }
};

var spaceOdyssey = new DVD
{
    Name = "SpaceOdyssey",
    SalesPrice = 19.95,
    RecommendedPlayer = haChi779
};

var matey = new MobilePhoneCase
{
    Name = "Matey",
    SalesPrice = 17.95
};

var mate0815 = new MobilePhone
{
    Name = "Mate0815",
    SalesPrice = 599.15,
    RecommendedCase = matey
};

// will show Matey, because RecommendedCase automatically populates the Recommends reference
Console.WriteLine("Mate0815 recommends " + string.Join(", ", ((IProduct)(mate0815)).Recommends));

var allProducts = new Namespace
{
    Name = "Products",
    Uri = new Uri("https://example.org/products"),
    Prefix = "p",
    Types =
    {
        mobyDick,
        spaceOdyssey,
        haChi779,
        matey,
        mate0815
    }
};

var model = new Model { ModelUri = allProducts.Uri, RootElements = { allProducts } };

var repository = new ModelRepository();
repository.Save(model, Path.Combine("..", "..", "..", "..", "ItemsGenerator", "products.nmeta"));

var code = MetaFacade.CreateCode(allProducts, "Hsrm.DeepModeling.Warehouse.Products");
MetaFacade.GenerateCode(code, new CSharpCodeProvider(), Path.Combine("..", "..", "..", "..", "ItemsGenerator", "Metamodel"), true);