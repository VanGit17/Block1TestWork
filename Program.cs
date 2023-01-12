/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.*/
Console.WriteLine("введите элементы строчного массива через пробел:");
string row = Console.ReadLine();
string[] strings = row.Split(' ');
void ArrayPrint (string[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"<<{a[i]}>>, ");
Console.WriteLine($"<<{a[a.Length-1]}>>]");
}

Console.WriteLine("Задан массив строк:");
ArrayPrint(strings);

int ThreeSignCount =0;
for (int i = 0; i < strings.Length; i++)
{
    if(strings[i].Length<=3) ThreeSignCount++;
}

if(ThreeSignCount>0)
{

string[] ThreeSignStrings = new string[ThreeSignCount];

int j=0;
for (int i = 0; i < strings.Length; i++)
{
    if(strings[i].Length<=3) 
    {
        ThreeSignStrings[j]=strings[i];
           j++;
    }
}
Console.WriteLine();

Console.WriteLine("массив из заданных строк, длина которых не превышает 3 символа:");
ArrayPrint(ThreeSignStrings);

}
else Console.WriteLine("В заданном массиве отсутствуют элементы длина которых не превышает три символа!");