// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int i = 0, j = text.Length - 1;
while ((i<j) && (text[i] == text[j]))
{
    i++; j--;
}
if(text[i] == text[j])
Console.WriteLine(text +" - это палиндром!");
else
Console.WriteLine(text +" - это не палиндром!");
