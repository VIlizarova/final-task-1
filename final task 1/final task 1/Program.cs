// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("введите слова через запятую");

string[] arr = Console.ReadLine().Split(',');

int[] tmp = new int[arr.Length];

int j = 0;

for (int i = 0; i < arr.Length; i++)
    {
               if (arr[i].Length <= 3 & arr[i] != (""))
            {
                
                tmp[j] = i;
                
                j++;
            }
    }

if (j == 0)
    {
        Console.WriteLine("не введено ни одного слова, соответсвующего условиям");
        return;
    }
   
string[] final = new string [j];
Console.WriteLine(final.Length);
for (int i = 0; i < j; i++)
    {
                final[i] = arr[tmp[i]];
    }


Console.WriteLine("Сортированный массив");
        for(Int32 i =0; i< final.GetLength(0);i++)
            
                    {
                        Console.Write(final[i] + "\t");
                    }
                Console.WriteLine("");