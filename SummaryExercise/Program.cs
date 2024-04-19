using DataHandler.Print;
using DataHandler.Search;
using Retriever;
using SummaryExercise;


using var context = new CsvContext("Rub.csv");

context.RetrieveData();

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

totalHandler.Remove(itemdacancellare);

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
//attenzione che questo non funziona... perchè gli oggetti vanno per riferimento
totalHandler.Remove(itemdacancellare2);

//questo funziona
totalHandler.SecureRemove(itemdacancellare2);




