#region Spliter
string underscoreText = "Lets_Solve_This_Problem";

string commaText = "Lets, Solve, This, Problem";

string text = "Lets$Solve,This_Problem@Working";

//var results = underscoreText.Split('_');
//var results = commaText.Split(',');
var results = text.Split('_', ',', '$', '@');

Console.WriteLine(results);
Console.WriteLine(results.Length);

foreach (var item in results)
{
	Console.WriteLine(item);
}
#endregion

//Array & string methods
//length
//indexOf
//substring
//sort
//replace
//trim
//split
