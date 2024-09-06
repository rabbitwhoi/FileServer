
Console.WriteLine("Введите периметр: ");
string input = Console.ReadLine();

double p = Convert.ToInt16(input);


double s1 = (p / 4);

double s = s1 * s1;
//double result = Math.Pow(s1, 2);

Console.WriteLine("Площадь ровна: " + s);
