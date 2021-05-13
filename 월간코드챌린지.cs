using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long[] solution(long[] numbers) {
        long[] answer = new long[numbers.Length];
        List<char> sen = new List<char>();
        List<char> sen2 = new List<char>();
        for(int i=0; i<numbers.Length; i++)
        {
            long temp =numbers[i];
            string n_string = Convert.ToString(numbers[i], 2);
            sen= n_string.ToList();
            while(true)
            {
                temp++;
                string n_string2 = Convert.ToString(temp, 2);
                sen2 = n_string2.ToList();
                if(sen.Count != sen2.Count)
                {
                    sen.Insert(0,'0');
                }
                int one=0;
                for (int j =0; j<sen2.Count; j++)
                {
                    if (sen[j] != sen2[j])
                    {
                        one++;
                    }
                    if(one>2) 
                    {
                        break;
                    }
                }
                if(one<=2)
                {
                    answer[i]+=temp;
                    break;
                }
            }
        }
        return answer;
    }
}



using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int j=left; j<=right; j++)
        {
            int count=0;
            for(int i=1;i<=j; i++)
            {
                if(j%i==0)
                {
                    count++;
                }
            }
            if(count %2==0) answer+=j;
            else answer -= j;        
        }
        return answer;
    }
}