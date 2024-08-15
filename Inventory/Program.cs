using Hsrm.DeepModeling.Warehouse.Products.MyWarehouse;
using Hsrm.DeepModeling.Warehouse.Products.Products;
using Hsrm.DeepModeling.Warehouse.Warehouse;
using NMF.Models;
using NMF.Models.Repository;

var mb1 = new MobyDick();
var mb2 = new MobyDick
{
    Return = new Return
    {
        ReturnDate = new DateTime(2023, 03, 23)
    },
    Sale = new SalePrice
    {
        ReducedPrice = 1.95
    }
};
var energetic = new AABatteryCell
{
    SalesPrice = 17.95,
    Quantity = 10,
    Stock = 271820
};

var inventory = new Inventory
{
    Items = { mb1, mb2 },
    BulkProducts = { energetic }
};

double EffectiveSalesPrice(ISaleItem saleItem)
    => saleItem.Sale?.ReducedPrice ?? saleItem.GetIndividualProduct().SalesPrice;

var pricesPerProduct = from item in inventory.Items
                       group item by item.GetIndividualProduct() into itemsOfProduct
                       select new
                       {
                           Product = itemsOfProduct.Key,
                           SummedSalesPrices = itemsOfProduct.Sum(EffectiveSalesPrice)
                       };

foreach (var prod in pricesPerProduct)
{
    Console.WriteLine($"Total for {prod.Product}: {prod.SummedSalesPrices} {prod.Product.GetProductSpecification().Currency}");
}

var repository = new ModelRepository();
repository.Save(inventory, "inventory.xmi");