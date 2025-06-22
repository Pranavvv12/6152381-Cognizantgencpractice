
using System;
using System.Linq;

public class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Category: {Category}");
    }
}

class Program
{
    public static Product LinearSearch(Product[] products, string nameToFind)
    {
        foreach (Product p in products)
        {
            if (p.ProductName.Equals(nameToFind, StringComparison.OrdinalIgnoreCase))
            {
                return p;
            }
        }
        return null;
    }

    public static Product BinarySearch(Product[] sortedProducts, string nameToFind)
    {
        int left = 0;
        int right = sortedProducts.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int compare = string.Compare(sortedProducts[mid].ProductName, nameToFind, StringComparison.OrdinalIgnoreCase);

            if (compare == 0)
                return sortedProducts[mid];
            else if (compare < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main(string[] args)
    {
       

        Product[] productList = {
            new Product(101, "Mouse", "Electronics"),
            new Product(102, "Keyboard", "Electronics"),
            new Product(103, "Shirt", "Clothing"),
            new Product(104, "Monitor", "Electronics"),
            new Product(105, "Shoes", "Footwear")
        };

       
        Product linearResult = LinearSearch(productList, "Shirt");

        if (linearResult != null)
            linearResult.Display();
        else
            Console.WriteLine("Product not found.\n");

        Product[] sortedList = productList.OrderBy(p => p.ProductName).ToArray();
        Product binaryResult = BinarySearch(sortedList, "Keyboard");

        if (binaryResult != null)
            binaryResult.Display();
        else
            Console.WriteLine("Product not found.\n");

      

    }
}
