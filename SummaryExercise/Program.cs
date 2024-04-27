using DataHandler.Print;
using DataHandler.Search;
using Retriever;
using SummaryExercise;


//using var context = new CsvContext("Rub.csv");

//context.RetrieveData();

string stringConnection = @"Data Source=ross\sqlexpress;Initial Catalog=Items;Integrated Security=True;Encrypt=False";
using DbContext context = new(stringConnection);
context.Open();

var handler = new PureHandler(new CellphoneDataHandler(context), new ConsolePrint());

handler.Print(handler.Search("Maria"));

var totalHandler = new TotalDataHandler(context);
var itemSearched = totalHandler.SpecialSearch("Maria").ToList();
foreach (var item in itemSearched)
{
    Console.WriteLine(item.ToString());
}


//funziona
var itemdacancellare = itemSearched.First();

if (!totalHandler.Remove(itemdacancellare))
    Console.WriteLine("Prima rimozione non funziona");
else
    Console.WriteLine("Prima rimozione andata a buon fine");
if (!handler.Add(itemdacancellare))
    Console.WriteLine("Primo inserimento non funziona");
else
    Console.WriteLine("Primo inserimento andato a buon fine");

//Rossana;Mazzuconi;via Bosi;Gotham;8417678500;Rossana.Mazzuconi@email.euris

var itemdacancellare2 = new Item
{
    Address = "via Bosi",
    City = "Gotham",
    Email = "Rossana.Mazzuconi@email.euris",
    Mobile = "8417678500",
    Name = "Rossana",
    Surname = "Mazzuconi",
};

if (!totalHandler.Remove(itemdacancellare2))
    Console.WriteLine("Seconda rimozione non funziona");
else
    Console.WriteLine("Seconda rimozione andata a buon fine");
if (!handler.Add(itemdacancellare2))
    Console.WriteLine("Secondo inserimento non funziona");
else
    Console.WriteLine("Secondo inserimento andato a buon fine");

//questo funziona
if (!totalHandler.SecureRemove(itemdacancellare2))
    Console.WriteLine("Terza rimozione non funziona");
else
    Console.WriteLine("Terza rimozione andata a buon fine");
if (!handler.Add(itemdacancellare2))
    Console.WriteLine("Terzo inserimento non funziona");
else
    Console.WriteLine("terzo inserimento andato a buon fine");



