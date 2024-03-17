using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Задача 7.1
//Products productone = new Products("banana", (Category)3, 120, 10);
//Products producttwo = new Products("apple", (Category)3, 220, 5);
//Products[] products = [productone, producttwo];
//while (true)
//{
//Console.WriteLine("Select action:\n[1]-Show list of products\n[2]-Add new product\n[3]-Remove product\n[4]-Edit product\n[5]-Exit");
//int temp = int.Parse(Console.ReadLine());
//switch (temp)
//{
//case 1:
//Console.WriteLine("List of product:\n");
//foreach (Products product in products)
//{
//product.PrintProductInfo();
//}
//break;
//case 2:
//Products producttemp = new Products();
//producttemp = producttemp.CreateNewProduct();
//products = producttemp.AddProduct(products);
//break;
//case 3:
//Console.WriteLine("Enter name of product wich you want remove:");
//string tempname = Console.ReadLine();
//for (int i = 0; i < products.Length; i++)
//{
//if (products[i].name == tempname)
//{
//products = products[i].DelProduct(products);
//}
//}
//break;
//case 4:
//Console.WriteLine("Enter name of element wich you want edit:");
//tempname = Console.ReadLine();
//for (int i = 0; i < products.Length; i++)
//{
//if (products[i].name == tempname)
//{
//products[i].EditProduct();
//}
//}
//break;
//case 5:
//return;
//default:
//break;
//}
//}
//enum Category
//{
//    Industrial_products = 1,
//    Household_chemicals,
//    Food

//}
//struct Products(string _name, Category _category, float _price, int _quantity)
//{
//    public string name = _name;
//    private Category category = _category;
//    private float price = _price;
//    private int quantity = _quantity;

//    public void PrintProductInfo()
//    {
//        Console.WriteLine($"Product name:{name}\nProduct Category:{category}\nProduct price:{price}\nProduct quantity:{quantity}\n");
//    }
//    public void EditProduct()
//    {
//        Console.WriteLine("Select option to edit:\n[1]-Edit name\n[2]-Edit Category\n[3]-Edit price\n[4]-Edit quantity");
//        int temp = int.Parse(Console.ReadLine());
//        switch (temp)
//        {
//            case 1:
//                Console.WriteLine($"Enter new name(current:{name}):");
//                name = Console.ReadLine();
//                break;
//            case 2:
//                Console.WriteLine($"Enter new category(current:{category}):\nAvailable category:\n[1]-Industrial_products\n[2]-Household_chemicals\n[3]-Food");
//                int tempcategory = int.Parse(Console.ReadLine());
//                category = (Category)tempcategory;
//                break;
//            case 3:
//                Console.WriteLine($"Enter new price(current:{price}):");
//                price = float.Parse(Console.ReadLine());
//                break;
//            case 4:
//                Console.WriteLine($"Enter new quantity(current:{price}):");
//                quantity = int.Parse(Console.ReadLine());
//                break;
//            default:
//                break;
//        }
//    }
//    public Products[] AddProduct(Products[] product)
//    {
//        Products newproduct = new Products(name, category, price, quantity);
//        Products[] newlist = new Products[product.Length + 1];
//        for (int i = 0; i < product.Length; i++)
//        {
//            newlist[i] = product[i];
//        }
//        newlist[newlist.Length - 1] = newproduct;
//        product = newlist;
//        return product;
//    }
//    public Products[] DelProduct(Products[] product)
//    {
//        int temp = 0;
//        Products[] arraynew = new Products[product.Length - 1];
//        for (int i = 0; i < arraynew.GetLength(0); i++)
//        {
//            if (product[i].name == name)
//            {
//                arraynew[i] = product[temp + 1];
//                temp += 2;
//                continue;
//            }
//            arraynew[i] = product[temp];
//            temp++;
//        }

//        return arraynew;
//    }
//    public Products CreateNewProduct()
//    {
//        Console.WriteLine("Enter product name:");
//        string name = Console.ReadLine();
//        Console.WriteLine($"Enter category:\nAvailable category:\n[1]-Industrial_products\n[2]-Household_chemicals\n[3]-Food\n");
//        int category = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter price:");
//        float price = float.Parse(Console.ReadLine());
//        Console.WriteLine("Enter quantity:");
//        int quantity = int.Parse(Console.ReadLine());
//        Products producttemp = new Products(name, (Category)category, price, quantity);
//        return producttemp;
//    }
//}


//Задача 7.2-7.3


//Authors[] authors = [new Authors("Taras", "Shevchenko", DateTime.Parse("02/05/1956")), new Authors("Lina", "Kostenko", DateTime.Parse("12/10/1942")), new Authors("Ivan", "Franko", DateTime.Parse("23/08/1966"))];
//Books[] books = [new Books("1", authors[1], 2000, "City"), new Books("2", authors[2], 1980, "City"), new Books("3", authors[0], 2020, "City"), new Books("4", authors[1], 2013, "City"), new Books("5", authors[0], 1999, "City")];
//while (true)
//{
//Console.WriteLine("Select action:\n[1]-Show list of book\n[2]-Add new book\n[3]-Remove book\n[4]-Edit book\n[5]-Exit");
//int temp = int.Parse(Console.ReadLine());
//switch (temp)
//{
//case 1:
//Console.WriteLine("Show full information?\n[y]-yes\n[n]-no\n");
//char tempchar = ' ';
//tempchar = char.Parse(Console.ReadLine());
//bool showFullInformation = false;
//switch (tempchar)
//{
//case 'y':
//showFullInformation = true;
//break;
//case 'n':
//showFullInformation = false;
//break;
//default: break;
//}
//Console.WriteLine("List of books:\n");
//foreach (Books book in books)
//{
//book.Print(showFullInformation);
//}
//break;
//case 2:
//Books booktemp = new Books();
//booktemp = booktemp.CreateNewBook(authors);
//books = booktemp.AddBook(books);
//break;
//case 3:
//Console.WriteLine("Enter title of book wich you want remove:");
//string tempname = Console.ReadLine();
//for (int i = 0; i < books.Length; i++)
//{
//if (books[i].title == tempname)
//{
//books = books[i].DelBook(books);
//}
//}
//break;
//case 4:
//Console.WriteLine("Enter name of book wich you want edit:");
//tempname = Console.ReadLine();
//for (int i = 0; i < books.Length; i++)
//{
//if (books[i].title == tempname)
//{
//books[i].EditBook(authors);
//}
//}
//break;
//case 5:
//return;
//default:
//break;
//}
//}
//struct Authors(string _name, string _last_name, DateTime _birthday)
//{
//    public string name = _name;
//    public string last_name = _last_name;
//    public DateTime birthday = _birthday;
//    public void Print()
//    {
//        Console.WriteLine($"Author:{name} {last_name}\nDate of birth of the author:{birthday.ToShortDateString()}\n");
//    }
//}
//struct Books(string _title, Authors _author, int _year, string _place)
//{
//    public string title = _title;
//    Authors author = _author;
//    int year = _year;
//    string place = _place;
//    public void Print(bool shooFullInfo)
//    {
//        if (shooFullInfo)
//        {
//            Console.WriteLine($"Title:{title}\nAuthor:{author.name} {author.last_name}\nDate of birth of the author:{author.birthday.ToShortDateString()}\nYear:{year}\nPlace:{place}\n");
//        }
//        else Console.WriteLine($"Title:{title}\nAuthor:{author.name} {author.last_name}\n");
//    }


//    public Books[] AddBook(Books[] books)
//    {
//        Books newbook = new Books(title, author, year, place);
//        Books[] newlist = new Books[books.Length + 1];
//        for (int i = 0; i < books.Length; i++)
//        {
//            newlist[i] = books[i];
//        }
//        newlist[newlist.Length - 1] = newbook;
//        books = newlist;
//        return books;
//    }
//    public Books[] DelBook(Books[] books)
//    {
//        int temp = 0;
//        Books[] arraynew = new Books[books.Length - 1];
//        for (int i = 0; i < arraynew.GetLength(0); i++)
//        {
//            if (books[i].title == title)
//            {
//                arraynew[i] = books[temp + 1];
//                temp += 2;
//                continue;
//            }
//            arraynew[i] = books[temp];
//            temp++;
//        }

//        return arraynew;
//    }
//    public Books CreateNewBook(Authors[] authors)
//    {
//        Console.WriteLine("Enter book title:");
//        string title = Console.ReadLine();
//        Console.WriteLine($"Enter author name:\nAvailable author:");
//        foreach (Authors author in authors)
//        {
//            author.Print();
//        }
//        string authorname = Console.ReadLine();
//        Authors authortemp = new Authors();
//        foreach (Authors author in authors)
//        {
//            if (author.name == authorname)
//            {
//                authortemp = author;
//            }
//        }
//        Console.WriteLine("Enter year:");
//        int year = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter place:");
//        string place = Console.ReadLine();
//        Books booktemp = new Books(title, authortemp, year, place);
//        return booktemp;
//    }
//    public void EditBook(Authors[] authors)
//    {
//        Console.WriteLine("Select option to edit:\n[1]-Edit title\n[2]-Edit Author\n[3]-Edit year\n[4]-Edit place");
//        int temp = int.Parse(Console.ReadLine());
//        switch (temp)
//        {
//            case 1:
//                Console.WriteLine($"Enter new title(current:{title}):");
//                title = Console.ReadLine();
//                break;
//            case 2:
//                Console.WriteLine($"Enter author name:\nAvailable author:");
//                foreach (Authors author in authors)
//                {
//                    author.Print();
//                }
//                string authorname = Console.ReadLine();
//                foreach (Authors authortemp in authors)
//                {
//                    if (author.name == authorname)
//                    {
//                        author = authortemp;
//                    }
//                }
//                break;
//            case 3:
//                Console.WriteLine($"Enter new year(current:{year}):");
//                year = int.Parse(Console.ReadLine());
//                break;
//            case 4:
//                Console.WriteLine($"Enter new place(current:{place}):");
//                place = Console.ReadLine();
//                break;
//            default:
//                break;
//        }
//    }
//}


Goods[] goods = [new Goods(21312,"Shirt",(Brands)1,1232,10),
    new Goods(21231,"jacket",(Brands)2,11232,1),
    new Goods(6543,"Shoes",(Brands)3,12432,20),
    new Goods(123243,"qwerew",(Brands)1,12732,5),
    new Goods(877865,"dfsklfdm",(Brands)2,12312,0),
    new Goods(54434,"Shirt",(Brands)5,12732,5),
    new Goods(87658,"vngbf",(Brands)4,12132,90),
    new Goods(123241,"Shirt",(Brands)1,12392,100)];
Brands[] brands = (Brands[])Enum.GetValues(typeof(Brands));  
while (true)
{
    Console.WriteLine("Select action:\n[1]-Show list of goods\n[2]-Sell Goods\n[3]-Show goods by brand\n[4]-Add goods\n[5]-Exit");
    int temp = int.Parse(Console.ReadLine());
    switch (temp)
    {
        case 1:
            foreach (Goods good in goods)
            {
                good.PrintGoods();
            }
            break;
        case 2: 
            Console.WriteLine("Enter article of goods:");
            int articletemp = int.Parse(Console.ReadLine());    
            for(int i=0;i<goods.Length;i++)
            {
                if (goods[i].article == articletemp)
                {
                    goods[i].SellGoods();
                }
            }
            break;
        case 3:
            foreach (Brands brand in brands)
            {
                Console.WriteLine(brand+":");
                foreach(Goods good in goods)
                {
                    if(good.brand == brand)
                    {
                        good.PrintGoods();
                    }
                }
                Console.WriteLine("------------------");

            }
            break;
        case 4:
            Goods newgood = new Goods();
            newgood.CreateNewGoods();
            goods = newgood.AddNewGoods(goods);
            break;
        case 5:
            return;
        default:
            break;
    }
}

enum Brands
{
    Adidas=1,
    Nike,
    Puma,
    Crop,
    Convers
}

struct Goods(int article,  string name, Brands brand, float price, int amount)
{
    public int article = article;
    string name =name;
   public Brands brand = brand;
    float price = price;
    int amount = amount;
    public void PrintGoods()
    {
        Console.WriteLine($"Goods article:{article}\nGoods name:{name}\nGoods brand:{brand}\nGoods price:{price}\nGoods count:{amount}\n");
    }
    public void SellGoods() 
    {
        if (amount > 0)
        {
            amount--;
            Console.WriteLine("Product has been successfully sold");

        }
        else
        {
            Console.WriteLine("Product is not available");
        }
    }
    public Goods[] AddNewGoods(Goods[] goods)
    {

        Goods newgoods = new Goods();
        Goods[] newlist = new Goods[goods.Length + 1];
        for (int i = 0; i < goods.Length; i++)
        {
            newlist[i] = goods[i];
        }
        newlist[newlist.Length - 1] = newgoods;
        goods = newlist;
        return goods;
    }
    public Goods CreateNewGoods()
    {
        Console.WriteLine("Enter goods article:");
        int article = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter goods name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goods brand:\nAvailable brands:\n[1]-Adidas,\n[2]-Nike,\n[3]-Puma,\n[4]-Crop,\n[5]-Convers");
        int brandtemp;
        do
        {
            brandtemp = int.Parse(Console.ReadLine());

        }while(brandtemp<1&&brandtemp>5);
        Console.WriteLine("Enter price:");
        float price = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount:");
        int amount = int.Parse(Console.ReadLine());
        Goods goods = new Goods(article, name, (Brands)brandtemp, price,amount);
        return goods;
    }

}