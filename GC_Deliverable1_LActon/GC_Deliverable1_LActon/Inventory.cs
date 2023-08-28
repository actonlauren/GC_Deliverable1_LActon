// See https://aka.ms/new-console-template for more information

int sodaBaseStock = 100;
int sodaRestockQuantity = 40;
int chipsBaseStock = 40;
int chipsRestockQuantity = 20;
int candyBaseStock = 60;
int candyRestockQuantity = 40;

int sodaStringtoInt;
int chipsStringtoInt;
int candyStringtoInt;
int currentSodaStock;
int currentChipsStock;
int currentCandyStock;

List<string> itemsToBeRestocked = new List<string>();

Console.WriteLine("Welcome to the Restocking Tool\n");

Console.WriteLine($"How many sodas have been sold today? There are {sodaBaseStock} in stock currently");
string sodasSold = Console.ReadLine();

sodaStringtoInt = Convert.ToInt32(sodasSold);

currentSodaStock = sodaBaseStock - sodaStringtoInt;

if (sodaStringtoInt < sodaBaseStock)
{
    Console.WriteLine($"There are {currentSodaStock} sodas left.\n");
    if (currentSodaStock <= sodaRestockQuantity)
    {
        itemsToBeRestocked.Add("Soda");
    }
    else
        Console.WriteLine("At this time sodas do not need to be restocked.\n");

}
else
    Console.WriteLine("The value is too high, stock not adjusted.\n");

Console.WriteLine($"\nHow many chips have been sold today? There are {chipsBaseStock} in stock currently");
string chipsSold = Console.ReadLine();

chipsStringtoInt = Convert.ToInt32(chipsSold);
currentChipsStock = chipsBaseStock - chipsStringtoInt;

if (chipsStringtoInt < chipsBaseStock)
{
    Console.WriteLine($"There are {currentChipsStock} chips left.\n");
    if (currentChipsStock <= chipsRestockQuantity)
    {
        itemsToBeRestocked.Add("Chips");
    }
    else
        Console.WriteLine("At this time chips do not need to be restocked.\n");

}
else
    Console.WriteLine("The value is too high, stock not adjusted.\n");

Console.WriteLine($"\nHow many candies have been sold today? There are {candyBaseStock} in stock currently");
string candySold = Console.ReadLine();

candyStringtoInt = Convert.ToInt32(candySold);
currentCandyStock = candyBaseStock - candyStringtoInt;

if (candyStringtoInt < candyBaseStock)
{
    Console.WriteLine($"There are {currentCandyStock} candies left.\n");
    if (currentCandyStock <= candyRestockQuantity)
    {
        itemsToBeRestocked.Add("Candy");
    }
    else
        Console.WriteLine("At this time candies do not need to be restocked.\n");

}
else
    Console.WriteLine("The value is too high, stock not adjusted.\n");

if (itemsToBeRestocked.Count() >= 1)
{
    Console.WriteLine("Thank you for your input. The following items need to be restocked:");

}
Console.WriteLine(string.Join(",", itemsToBeRestocked));
Console.WriteLine("\nThank you for using the restock helper!\n");
