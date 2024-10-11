// from A to B and C

interface iUser
{
    void getDetails(string x);
}

class User : iUser
{
    public void getDetails(string name)
    {
        Console.WriteLine("My name is {0}", name);
    }
}

class User2 : iUser
{
    public void getDetails(string address)
    {
        Console.WriteLine("My address is {0}", address);
    }
}

class Program
{
    static void Main()
    {
        iUser u = new User();
        u.getDetails("John Doe");

        iUser u2 = new User2();
        u2.getDetails("123 Main St");
    }
}

// from A and B to C
interface iUser
{
    void getName(string x);
}

interface iAddress
{
    void getAddress(string a);
}

class User : iUser, iAddress
{
    public void getName(string name)
    {
        Console.WriteLine("My name is {0}", name);
    }
    public void getAddress(string address)
    {
        Console.WriteLine("My address is {0}", address);
    }
}

class Program
{
    static void Main()
    {
        User u = new User();
        u.getName("John Doe");
        u.getAddress("123 Main St");
    }
}