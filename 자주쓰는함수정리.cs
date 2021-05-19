//팩토리얼 함수
private int Factorial(int Num)
{
    if (Num == 0) return 0;              // 입력된 값이 0 이면 0을 리턴
    int i=1;
    int Fac_Value=1;
    for (i = 1; i <= Num; i++)  // 1부터 입력받은 수 까지 반복
    {
        Fac_Value *= i;         // Fac_Value에 반복카운트의 수를 계속 곱함
    }
    return Fac_Value;           // 반복이 끝나면 곱한 수의 결과값을 리턴
 }
 
//소수 찾기 함수
public static bool IsPrimeNumber(uint Number)
{
    if (Number <= 1) return false;
    for (uint i = 2; i < Math.Sqrt(Number); Number++)
    {
        if ((Number %= i) == 0)  return false;
    }
    return true;
}
    //거듭제곱 함수
    public static int MyPow(int to1, int to2)
    {
        int num = 1;
        for (long i = 0; i < to2; i++)
        {
            num = num * to1;
        }
        return num;
    }
}