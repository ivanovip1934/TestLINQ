using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var colloction = new List<int>();
            for (int i = 0; i < 10; i++)
                colloction.Add(i);

            var result = from item in colloction
                         where item < 5
                         select item;

            var result2 = colloction.Where(item => item < 5);
            var result3 = colloction.Sum();
            

            Console.WriteLine(result.Count().ToString());
            Console.WriteLine(result2.Count().ToString());
            Console.WriteLine(result3.ToString());



            //int[] array1 = { 1, 2, 3, 4, 5, 7, 3, 4 };
            int[] array2 = {4, 5, 6, 2, 3, 6, 5, 1};
            
            
            Console.WriteLine(array2.Length.ToString());
            int[] array1 =array2.Distinct().ToArray();
            
            // Пропускаем "Skip()" кол-во элементов в начале
            // и берез "Take()" заданное кол-во элементов.
            int[] array3 = array2.Skip(1).Take(3).ToArray();

            // Берем первый элемент из элементов удовлетворяющих условию "Item == 5"
            // Если ни одного элемента ни будет найдено или переменная не имеет значения
            // тогда вылетит исключение
            int first = array2.First(item => item == 5);
            // Просто берем первый элемент.
            // Если ни одного элемента ни будет найдено или переменная не имеет значения
            // тогда вылетит исключение
            int first1 = array2.First();

            // Может работать с пустыми переменными.    
            int first2 = array2.FirstOrDefault();


            // Находим единственный элемент удовлетворяющий условию.
            // Если будет больше одного - вылетит Exception.
            // Поэтому используется для получения ключа из базы.
            int singl = array2.Single(item => item == 1);



            // Взять елемент по индексу в коллекцие.
            // Индекс начинается с 0.
            int varOnIndex = array2.ElementAt(5);
            Console.WriteLine("varOnIndex = {0}", varOnIndex);
            int sum = array2.Sum();
            int min = array2.Min();
            int aggregate = array2.Aggregate((x, y) => x * y);
            Print(array2);
            Print(array1);
            Print(array3);

            Console.WriteLine(array1.Count().ToString());
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min Value = {0}", min);
            Console.WriteLine("Aggregate = {0}", aggregate);
            Console.ReadKey();          



        }

        static void Print(int[] array)
        {
            Console.Write("Значения элементов в массиве: ");
            foreach (int item in array)
                Console.Write(" ({0})", item);
            Console.WriteLine();

        }                   
    }
}
