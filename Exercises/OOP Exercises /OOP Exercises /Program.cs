// This is a library system program that manages books, loanees and loans in a library.

/*public class Library
{
    private List<Book> Books  = new List<Book>();
    private List<LibraryUser> Users = new List<LibraryUser>();



    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddUser(LibraryUser user)
    {
        Users.Add(user);
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Books available");
        foreach (var book in Books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN})");
        }

        Console.WriteLine("\nLibrary Users:");
        foreach (var user in Users)
        {
            Console.WriteLine($"- {user.Name} (ID: {user.UserId})");
        }
        
    }


}

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    public class LibraryUser
    {
        public string Name { get; set; }
        public string UserId { get; set; }
    }

    public class Loan
    {
        public Book LoanedBook { get; set; }
        public LibraryUser Loanee { get; set; }
    }
*/


/*
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool InStock { get; set; }


    public Product(string name, decimal price, bool inStock)
    {
        Name = name;
        Price = price;
        InStock = inStock;
    }
}

public class Customer
{
    public string Name { get; set; }
    public List<Product> PurchasedProducts { get; set; }

    public Customer(string name)
    {
        Name = name;
        PurchasedProducts = new List<Product>();
    }
    
}


public class ShoppingCart
{
    private List<Product> items;

    public ShoppingCart()
    {
        items = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (product.InStock)
        {
            items.Add(product);
        }
        else
        {
            Console.WriteLine($"{product.Name} is out of stock");
        }
    }

    public decimal GetTotalAmount()
    {
        return items.Sum(item => item.Price);
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping cart contains:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} - ${item.Price}");
        }

        Console.WriteLine($"Total: ${GetTotalAmount()}");
    }


    public void Checkout()
    {
        Console.WriteLine("=== Receipt ===");
        DisplayCart();
        Console.WriteLine("Thank you for your purchase!");
        items.Clear();
    }
}
*/

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }

    public Character( string name, int health, int strength)
    {
        Name = name;
        Health = health;
        Strength = strength;
    }

    public virtual void Attack(Character target)
    {
        int damage = Strength;
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.ReceiveDamage(damage);
    }

    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} now has {Health} health remaining.");
    }

    public bool IsDefeated()
    {
        return Health <= 0;
    }
    
}

public class Warrior : Character
{
    public string Weapon { get; set; }

    public Warrior(string name, int health, int strength, string weapon) : base(name, health, strength)
    {
        Weapon = weapon;
    }

    public override void Attack(Character target)
    {
        int damage = Strength + 2;
        Console.WriteLine($"{Name} attacks {target.Name} with {Weapon} for {damage} damage!");
        target.ReceiveDamage(damage);
    }
    
}

public class Mage : Character
{
   public string Spell { get; set; }

   public Mage(string name, int health, int strength, string spell) : base(name, health, strength)
   {
       Spell = spell;
   }

   public override void Attack(Character target)
   {
       int damage = Strength + 3;
       Console.WriteLine($"{Name} casts {Spell} on {target.Name} for {damage} damage!");
       target.ReceiveDamage(damage);
   }
   

}

