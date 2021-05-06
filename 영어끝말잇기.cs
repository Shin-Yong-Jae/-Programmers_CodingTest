using System;
using System.Collections.Generic;
using System.Collections;
class Solution
{
    public int[] solution(int n, string[] words)
    {
        List<String> wordlist = new List<String>();
        int turncount =0;
        int usercount =0;
        
        for(int i=0; i<words.Length; i++)
        {
            if(i%n ==0) turncount++;
            
            if(i==0) 
            {
                wordlist.Add(words[i]);
                continue;
            }
            char checklast = words[i-1][words[i-1].Length-1];
            if(checklast != words[i][0] ||wordlist.Contains(words[i]))
            {
                usercount = (i%n) +1;
                break;
            }
            else
                wordlist.Add(words[i]);
        }
        if (usercount ==0)
            return new int[2]{0,0};
        else
            return new int[2]{usercount,turncount};
    }
}