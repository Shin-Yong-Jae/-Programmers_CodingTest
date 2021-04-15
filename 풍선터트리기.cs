using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] a) {
        int answer = a.Length;
        int leftmin = a[0]; //left 초기값
        int rightmin = a[a.Length-1]; //right 초기값
        List<bool> temp = new List<bool>(); 
        for(int i=0; i<a.Length; i++)
        {
            temp.Add(false);
        }
        
        for(int i=0; i<a.Length; i++)
        {
            if(leftmin<a[i])
            {
                temp[i]=true;
            }
            else
            {
                temp[i] =false;
                leftmin = a[i];
            }
        }
        for(int i=a.Length-2; i>=0; i--)
        {
            if(rightmin > a[i])
            {
                rightmin = a[i];
            }
            else if(temp[i]==true)
            {
                answer--;
            }
        }
        return answer;
    }
}