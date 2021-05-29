using System;
class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        string bin = Convert.ToString(n, 2);
        int count = bin.Length - bin.Replace("1", "").Length;
        //(2진수)string 문자열에서 1이아닌 값을 뺌 = 2진수 1의 개수
        for(int i=n+1; i<1000000; i++)
        {
            string a=Convert.ToString(i, 2);
            int acount = a.Length - a.Replace("1", "").Length;
            if(acount==count)
            {
                answer=i;
                break;
            }
        }
        return answer;
    }
}