using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        Array.Sort(numbers);
        List<int> temp =  new List<int>();
        for(int i=0; i<numbers.Length; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                temp.Add(numbers[i]+numbers[j]);
            }
        }
        temp =temp.Distinct().ToList();
        answer =  temp.ToArray();
        Array.Sort(answer);
        return answer;
    }
}