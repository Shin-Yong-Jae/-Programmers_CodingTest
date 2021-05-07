using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int right = 0;
        int zeroCount =0;
        for(int i=0; i<lottos.Length; i++)
        {
            if(lottos[i]==0) 
            {
                zeroCount++;
            }
            if(lottos.Contains(win_nums[i]))
            {
                right++;
            }
        }
        int MaxCollect = zeroCount+right;
        int MinCollect = right;
        if(MinCollect==0) MinCollect++;
        if(MaxCollect==0) MaxCollect++;
        int[] answer = new int[] {7-MaxCollect,7-MinCollect};
        return answer;
    }
}