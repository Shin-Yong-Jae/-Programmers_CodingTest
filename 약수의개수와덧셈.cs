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