// See https://aka.ms/new-console-template for more information
using Microsoft.CSharp;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;
using System.ComponentModel.DataAnnotations;
using Attribute = NMF.Models.Meta.Attribute;

var doubleType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//Double");
var intType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//Integer");
var stringType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//String");
var dateTimeType = MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//DateTime");

var baseTypes = Class.ClassInstance.LookupReference("BaseTypes");
var referenceConstraints = Class.ClassInstance.LookupReference("ReferenceConstraints");
var attributeConstraints = Class.ClassInstance.LookupReference("AttributeConstraints");
var instanceOf = Class.ClassInstance.LookupReference("InstanceOf");

var productSpecification = new Class
{
    Name = "ProductSpecification",
    BaseTypes = { Class.ClassInstance },
    ReferenceConstraints =
    {
        new ReferenceConstraint { Constrains = referenceConstraints },
        new ReferenceConstraint { Constrains = attributeConstraints },
        new ReferenceConstraint { Constrains = instanceOf }
    },
    Attributes =
    {
        new Attribute { Name = "taxRate", LowerBound = 1, Type = doubleType },
        new Attribute { Name = "currency", LowerBound = 1, Type= stringType },
        new Attribute { Name = "introductionDate", LowerBound = 1, Type = dateTimeType }
    }
};
var product = new Class
{
    Name = "Product",
    BaseTypes = { MetaElement.ClassInstance },
    IsAbstract = true,
    Attributes =
    {
        new Attribute
        {
            Name = "salesPrice",
            LowerBound = 1,
            Type = doubleType,
        }
    },
    InstanceOf = productSpecification
};
product.References.Add(new Reference
{
    Name = "recommends",
    UpperBound = -1,
    ReferenceType = product
});
var bulkProduct = new Class
{
    Name = "BulkProduct",
    Attributes =
    {
        new Attribute { Name = "quantity", LowerBound = 1, Type = intType },
        new Attribute { Name = "stock", LowerBound = 1, Type = intType }
    },
    BaseTypes = { product }
};
var bulkProductSpecification = new Class
{
    Name = "BulkProductSpecification",
    BaseTypes = { productSpecification },
    ReferenceConstraints =
    {
        new ReferenceConstraint { Constrains = baseTypes, References = { bulkProduct } },
    }
};
var individualProduct = new Class
{
    Name = "IndividualProduct",
    IsAbstract = true,
    BaseTypes = { product, Class.ClassInstance },
    ReferenceConstraints =
    {
        new ReferenceConstraint { Constrains = referenceConstraints },
        new ReferenceConstraint { Constrains = attributeConstraints },
        new ReferenceConstraint { Constrains = instanceOf }
    }
};
var ret = new Class
{
    Name = "Return",
    Attributes =
    {
        new Attribute { Name = "returnDate", LowerBound = 1, Type = dateTimeType },
        new Attribute { Name = "reason", LowerBound = 1, Type = stringType }
    }
};
var salePrice = new Class
{
    Name = "SalePrice",
    Attributes =
    {
        new Attribute { Name = "reducedPrice", LowerBound = 1, Type = doubleType }
    }
};
var saleItem = new Class
{
    Name = "SaleItem",
    InstanceOf = individualProduct,
    IsAbstract = true,
    References =
    {
        new Reference { Name = "return", IsContainment = true, ReferenceType = ret },
        new Reference { Name = "sale", IsContainment = true, ReferenceType = salePrice }
    }
};
var inventory = new Class
{
    Name = "Inventory",
    References =
    {
        new Reference { Name = "bulkProducts", IsContainment = true, UpperBound = -1, ReferenceType = bulkProduct },
        new Reference { Name = "items", IsContainment = true, UpperBound = -1, ReferenceType = saleItem }
    }
};
productSpecification.ReferenceConstraints.Add(new ReferenceConstraint
{
    Constrains = baseTypes,
    References = { individualProduct }
});
individualProduct.ReferenceConstraints.Add(new ReferenceConstraint
{
    Constrains = baseTypes,
    References = { saleItem }
});

var ns = new Namespace
{
    Name = "Warehouse",
    Uri = new Uri("https://multi-workshop.github.io/warehouse/nmeta"),
    Prefix = "warehouse",
    Types =
    {
        product,
        productSpecification,
        bulkProduct,
        bulkProductSpecification,
        individualProduct,
        saleItem,
        salePrice,
        ret,
        inventory
    }
};

var model = new Model { ModelUri = ns.Uri, RootElements = { ns } };

var repository = new ModelRepository();
repository.Save(model, Path.Combine("..", "..", "..", "..", "Warehouse", "warehouse.nmeta"));

var code = MetaFacade.CreateCode(ns, "Hsrm.DeepModeling.Warehouse");
MetaFacade.GenerateCode(code, new CSharpCodeProvider(), Path.Combine("..", "..","..", "..", "Warehouse", "Metamodel"), true);