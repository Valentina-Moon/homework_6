/*Написать программу масштабирования фигуры 
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

System.Globalization.NumberFormatInfo numberInfo = System.Globalization.NumberFormatInfo.InvariantInfo;
Console.WriteLine("Введите координаты:");
string inputLine = Console.ReadLine();
Console.WriteLine("Введите множитель:");
double inputMult = double.Parse(Console.ReadLine(), numberInfo);
Console.WriteLine(ChangeSize(inputLine, inputMult));


string ChangeSize(string input, double multiple)
{
    string result = "";
    string[] points = input.Replace("(", "").Replace(")", "").Split(" ");
    foreach (string point in points)
    {
        string x = $"{double.Parse(point.Split(",")[0], numberInfo) * multiple}".Replace(",", ".");
        string y = $"{double.Parse(point.Split(",")[1], numberInfo) * multiple}".Replace(",", ".");
        result += $"({x},{y}) ";
    }
    return result;
}
