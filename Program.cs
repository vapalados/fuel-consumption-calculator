Console.WriteLine("Какой тип рассчета расхода топлива Вы используете? ");
Console.WriteLine("1 - Европейский, количество литров на 100 километров");
Console.WriteLine("2 - Американский, количество миль на 1 галлон");
Console.WriteLine("3 - Корейский/Арабский, количество литров на 1 километр");
double number = Convert.ToDouble(Console.ReadLine());
if(number == 1)
{
Console.WriteLine("Ведите расход литров на 100 километров");
double number2 = Convert.ToDouble(Console.ReadLine());
double kor = number2 / 100;
double kor1 = 1 / kor;
Console.WriteLine($"Значение расхода топлива в Корее/ОАЭ будет: {Math.Round(kor1 , 2)} километров на 1 литр");
double amer = kor1 * 2.35215;
Console.WriteLine($"Значение расхода топлива в США будет: {Math.Round(amer , 2)} миль на 1 галлон");
}
if(number == 2)
{
Console.WriteLine("Ведите количество миль на 1 галлон");
double number2 = Convert.ToDouble(Console.ReadLine());
double kor = number2 / 2.35215;
double rus = 235.215 / number2;
Console.WriteLine($"Значение расхода топлива в Корее/ОАЭ будет: {Math.Round(kor , 2)} километров на 1 литр");
Console.WriteLine($"Значение расхода топлива в Европе будет: {Math.Round(rus , 2)} литров на 100 километров");
}
if(number == 3)
{
Console.WriteLine("Ведите количество километров на 1 литр");
double number2 = Convert.ToDouble(Console.ReadLine());
double rus = 100 / number2;
double amer = number2 * 2.35215;
Console.WriteLine($"Значение расхода топлива в Европе будет: {Math.Round(rus , 2)} литров на 100 километров");
Console.WriteLine($"Значение расхода топлива в США будет: {Math.Round(amer , 2)} миль на галлон");
}
if(number != 3 && number != 2 && number != 1)
{
    Console.WriteLine("Введите правильное значение.");
}
Console.WriteLine("Нажмите любую клавишу для выхода");
double number5 = Convert.ToDouble(Console.ReadLine());