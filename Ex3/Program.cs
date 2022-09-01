//Напишите программу,которая получает два числа А и В
// и возводит число А в целую степень В с помощью рекурсии


int DigitSum(int number, int step)
{
    if (step == 0)
    return 1;

   return (number*DigitSum(number, step - 1));
}

Console.WriteLine(DigitSum(2,5));