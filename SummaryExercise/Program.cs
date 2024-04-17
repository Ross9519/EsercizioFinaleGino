using SummaryExercise;
using SummaryExercise.Context;
using SummaryExercise.Print;
using SummaryExercise.Search;

using var context = new CSVContext("Rub.txt");

context.RetrieveData();

var handler = new PureHandler(new CellphoneDataHandler(context), new ConsolePrint());

handler.Print(handler.Search("Maria"));