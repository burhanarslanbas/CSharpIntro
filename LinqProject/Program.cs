
//Veri Kaynağı
using System.Linq;

//Veri Kaynağı
List<Category> categories = new List<Category>
{
	new Category{CategoryId=1,CategoryName="Bilgisayar"},
	new Category{CategoryId=2,CategoryName="Telefon"},
};

List<Product> products = new List<Product>
{
	new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
	new Product{ProductId=2,CategoryId=1,ProductName="Lenovo Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=3},
	new Product{ProductId=3,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
	new Product{ProductId=4,CategoryId=2,ProductName="Xiaomi Mi 12",QuantityPerUnit="256 GB Storage",UnitPrice=5000,UnitsInStock=15},
	new Product{ProductId=5,CategoryId=2,ProductName="iPhone 15 Pro Max",QuantityPerUnit="512 GB Storage",UnitPrice=8000,UnitsInStock=0}
};

//Linq
var result = products.Where(p=>p.UnitPrice>5000 && p.UnitsInStock > 3);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}

static List<Product> GetProductsWithAlghorithm(List<Product> products)
{
	List<Product> filteredProducts = new List<Product>();
	foreach (var product in products)
	{
		if(product.UnitPrice>5000 && product.UnitsInStock > 3)
        filteredProducts.Add(product);
    }
	return filteredProducts;
}
static List<Product> GetProductsWithLinq(List<Product> products)
{
	return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 0).ToList();	
}


foreach (var product in GetProductsWithLinq(products))
{
    Console.WriteLine(product.ProductName);
}


