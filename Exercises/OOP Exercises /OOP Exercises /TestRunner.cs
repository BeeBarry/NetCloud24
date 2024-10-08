using System;
namespace OOP_Exercises;


// This runs the library program.

class TestRunner
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book { Title = "Gösta Berlings saga", Author = "Selma Lagerlöf", ISBN = "9780143105909" });
        library.AddBook(new Book { Title = "Lapplandsresan", Author = "Carl Von Linné", ISBN = "9789187593598" });

        library.AddUser(new LibraryUser { Name = "Astrid Lindgren", UserId = "AL004" });
        library.AddUser(new LibraryUser { Name = "Erik Hermelin", UserId = "EH007" });

        library.DisplayInformation();
    }
}


// This runs the shopping program.

class Program
{
    static void Main(string[] args)
    {
        // Creating some products
        Product apple = new Product("Apple", 0.5m, true);
        Product banana = new Product("Banana", 0.3m, true);
        Product orange = new Product("Orange", 0.4m, true);
        Product pear = new Product("Pear", 0.6m, false);

        // Creating a customer
        Customer customer = new Customer("John Doe");

        // Creating a shopping cart
        ShoppingCart cart = new ShoppingCart();

        // Adding products to the cart
        cart.AddProduct(apple);
        cart.AddProduct(banana);
        cart.AddProduct(orange);
        cart.AddProduct(pear);
        
        // To display the current cart
        cart.DisplayCart();
        
        // To checkout and receive receipt
        cart.Checkout();
        
    }

}


// This runs the mage Vs warrior mini-game.

class Program
{
    static void Main(string[] args)
    {
         Warrior warrior = new Warrior("Legolas", 110, 5, "Mithril Sword");
         Mage mage = new Mage("Saruman", 90, 6, "Blast of darkness");

         while (!warrior.IsDefeated() && !mage.IsDefeated())
         {
             warrior.Attack(mage);
             if (!mage.IsDefeated())
             {
                 mage.Attack(warrior);
             }

             Console.WriteLine();
         }

         if (warrior.IsDefeated())
         {
             Console.WriteLine($"{mage.Name} wins!");
         }
         else
         {
             Console.WriteLine($"{warrior.Name} wins!");
         }



    }
    
}





