//Напишите программу,которая получает число и выводит сумма всех цифр этого числа
int DigitSum(int number)
{
    if (number == 0)
    return 0;

   return (number % 10) + DigitSum(number/10);
}

Console.WriteLine(DigitSum(632));