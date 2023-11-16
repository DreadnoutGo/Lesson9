int M1 = 1, N1 = 5;
Console.WriteLine($"M = {M1}; N = {N1} -> \"{PrintEvenNumbers(M1, N1)}\"");

int M2 = 4, N2 = 8;
Console.WriteLine($"M = {M2}; N = {N2} -> \"{PrintEvenNumbers(M2, N2)}\"");

static string PrintEvenNumbers(int m, int n)
{
    if (m > n)
    {
        return ""; // если m больше n, возвращаем пустую строку
    }

    // Рекурсивный случай: если m четное добавляем его к результату и вызываем функцию для следующего четного числа
    if (m % 2 == 0)
    {
        return m + (m < n - 1 ? ", " : "") + PrintEvenNumbers(m + 2, n);
    }
    // Если m нечетное вызываем функцию для следующего числа
    else
    {
        return PrintEvenNumbers(m + 1, n);
    }
}
