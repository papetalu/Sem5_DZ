// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-1000, 1000);
}

int ReleaseArray(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 != 0)
         sum = sum + array[i];
   }
   return sum;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(ReleaseArray(array));

