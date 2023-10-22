// See https://aka.ms/new-console-template for more information

using Classes2;

Product product1 = new Product() { ProductBrand = "asus", ProductPrice = 40000, UnitsInStock = 1000 }; 


ProductManager productManager = new ProductManager();

productManager.Add(product1);
