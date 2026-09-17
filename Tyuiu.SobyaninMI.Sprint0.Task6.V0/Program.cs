using Tyuiu.SobyaninMI.Sprint0.Task6.V0.Lib;

int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Сумма эллементов массива = " + DataService.AdditionArray(numsArray));
Console.WriteLine("Разность эллементов массива = " + DataService.SubtractionArray(numsArray));
Console.WriteLine("Произведение эллементов массива = " + DataService.MultiplicationArray(numsArray));

Console.ReadKey();