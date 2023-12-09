// Дан файл numsTask3.txt с целыми числами, вычислите среднее арифметическое элементов расположенных до минимального;

using System;
using System.IO;
using System.Linq;
class work_5_3
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask3.txt"); 
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); 

        int minIndex = Array.IndexOf(chosenUse, chosenUse.Min()); 
        double averageBeforeMin = chosenUse.Take(minIndex).Average(); 

        Console.WriteLine("Среднее арифметическое до минимального числа: " + averageBeforeMin); 
    }
}
