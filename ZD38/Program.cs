// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

void InputArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().NextDouble() * 10;
}

double MaxArray(double[] array)
{
   double max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] >= max)
         max = array[i];
   }
   return max;
}

double MinArray(double[] array)
{
   double min = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] <= min)
         min = array[i];
   }
   return min;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write("Максимальное число: ");
Console.WriteLine(MaxArray(array));
Console.Write("Минимальное число: ");
Console.WriteLine(MinArray(array));
double dif = MaxArray(array) - MinArray(array);

Console.Write("Разница между максимальным и минимальным числом = " + dif);