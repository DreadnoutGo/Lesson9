int M1 = 1, N1 = 15;
Console.WriteLine($"M = {M1}; N = {N1} -> {CalculateSum(M1, N1)}");

int M2 = 4, N2 = 8;
Console.WriteLine($"M = {M2}; N = {N2} -> {CalculateSum(M2, N2)}");


static int CalculateSum(int m, int n)
{
    if (m > n)
    {
        return 0; //если m больше n, возвращаем 0
    }

    //возвращаем сумму текущего числа и суммы для следующего числа
    return m + CalculateSum(m + 1, n);
}
