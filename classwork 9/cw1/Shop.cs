namespace cw1;

public class Shop
{
    List<Product> products =new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
    public void PrintProductList()
    {
        System.Console.WriteLine(products); 
    }
  
    
}
