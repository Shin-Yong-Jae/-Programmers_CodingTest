using System;

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