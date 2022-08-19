// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка)

int x;
Console.WriteLine("Введи тут число - ");
x = Convert.ToInt32(Console.ReadLine());

if(x % 2==0)
{
    Console.WriteLine("Yep, bro");
}
else
{
    Console.WriteLine("Nooope, really sory");
};
