// See https://aka.ms/new-console-template for more information
namespace Constructors;
class Program
{
    static void Main(string[] args)
    {
        Laptops laptop1 = new Laptops("Folio");
        laptop1.brand = "Hp";
        laptop1.model = "folio 9480";
        laptop1.processor = "intel core-i 5";
        laptop1.storageCapacity = "500GB";
        laptop1.RAM = "16GB";

        Laptops laptop2 = new Laptops("Dell");
        laptop2.brand = "Dell";
        laptop2.model = "Latitude 7440";
        laptop2.processor = "intel core-i 7";
        laptop2.storageCapacity = "500GB";
        laptop2.RAM = "32GB";

        Laptops laptop3 = new Laptops("MacBook");
        laptop3.brand = "MacBook Pro";
        laptop3.model = "2021";
        laptop3.processor = "intel core-i 7";
        laptop3.storageCapacity = "500GB";
        laptop3.RAM = "64GB";

                Console.ReadLine();
    }
}
