using System;
using System.ComponentModel;
using System.Diagnostics;
Products productone = new Products("banana",(Category)3,120,10);
Products producttwo = new Products("apple",(Category)3,220,5);
Products[] products = [productone, producttwo];
while (true)
{
    Console.WriteLine("Select action:\n[1]-Show list of products\n[2]-Add new product\n[3]-Remove product\n[4]-Edit product\n[5]-Exit");
    int temp =int.Parse(Console.ReadLine());
    switch (temp)
    {
        case 1:
            Console.WriteLine("List of product:\n");
            foreach (Products product in products){
                 product.PrintProductInfo();
            }
            break;
        case 2:
            Products producttemp =new Products();
            producttemp = producttemp.CreateNewProduct();
            products = producttemp.AddProduct(products);
            break;
        case 3:
            Console.WriteLine("Enter name of product wich you want remove:");
            string tempname = Console.ReadLine();
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].name == tempname)
                {
                   products =  products[i].DelProduct(products);
                }
            } 
            break;
        case 4:
            Console.WriteLine("Enter name of element wich you want edit:");
            tempname = Console.ReadLine();
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].name == tempname)
                {
                    products[i].EditProduct();
                }
            }
            break;
        case 5:
            return;
        default:
            break;
    }
}
enum Category
{
    Industrial_products=1,
    Household_chemicals,
    Food

}

struct Products(string _name, Category _category, float _price, int _quantity)
{
    public string name = _name;
    private Category category = _category;
    private float price = _price;
    private int quantity = _quantity;
     
    public void PrintProductInfo()
    {
        Console.WriteLine($"Product name:{name}\nProduct Category:{category}\nProduct price:{price}\nProduct quantity:{quantity}\n");
    }
    public void EditProduct()
    {
        Console.WriteLine("Select option to edit:\n[1]-Edit name\n[2]-Edit Category\n[3]-Edit price\n[4]-Edit quantity");
        int temp =int.Parse(Console.ReadLine());
        switch (temp)
        {
            case 1:
                Console.WriteLine($"Enter new name(current:{name}):");
                name = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine($"Enter new category(current:{category}):\nAvailable category:\n[1]-Industrial_products\n[2]-Household_chemicals\n[3]-Food");
                int tempcategory = int.Parse(Console.ReadLine());
                category = (Category)tempcategory;
                break;
            case 3:
                Console.WriteLine($"Enter new price(current:{price}):");
                price = float.Parse(Console.ReadLine());
                break;
            case 4:Console.WriteLine($"Enter new quantity(current:{price}):");
                quantity = int.Parse(Console.ReadLine());
                break;
            default:
                break;
        }
    }
    public Products[] AddProduct(Products[] product)
    {
        Products newproduct = new Products(name, category, price, quantity);
        Products[] newlist = new Products[product.Length+1];
        for(int i = 0; i < product.Length; i++)
        {
            newlist[i]=product[i];
        }
        newlist[newlist.Length-1] = newproduct;
        product = newlist;
        return product;
    }
    public Products[] DelProduct(Products[] product)
    {
        int temp =0;
        Products[] arraynew= new Products[product.Length-1];
        for(int i = 0; i < arraynew.GetLength(0); i++)
            {
            if (product[i].name ==name)
            {
                arraynew[i] = product[temp+1];
                temp+=2;
                continue;
            }
            arraynew[i]=product[temp];
            temp++;
        }
    
        return arraynew;
    }
    public Products CreateNewProduct()
    {
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter category:\nAvailable category:\n[1]-Industrial_products\n[2]-Household_chemicals\n[3]-Food\n");
            int category = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price:");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity:");
            int quantity = int.Parse(Console.ReadLine());
            Products producttemp = new Products(name,(Category)category,price,quantity);
            return producttemp;
    }
}