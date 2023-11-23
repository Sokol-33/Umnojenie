Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int b = int.Parse(Console.ReadLine());
int result = 0;
int number1 = Math.Sign(a);
int number2 = Math.Sign(b);

a = Math.Abs(a);
b = Math.Abs(b);
for (var i = 0; i < a; i++) result += b;
if (number1 == number2)
{
    Console.WriteLine("Ответ:" +result) ;
}
else
{
    Console.WriteLine("Ответ:" +(- result));
}