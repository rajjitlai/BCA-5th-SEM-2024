using System.Collections;
namespace arrayList;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrList = new ArrayList();
        arrList.Add("Hello");
        arrList.Add(120);
        arrList.Add(13.23);
        Console.Write("Array List Elements are: ");
        foreach(var item in arrList)
        {
            Console.WriteLine(item);
        }
    }
}