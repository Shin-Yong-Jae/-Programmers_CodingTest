using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        for(int i=0; i<skill_trees.Length; i++)
        {
            int k =skill_trees[i].Length; //이중반복문 돌릴범위 설정
            List<char> empty = new List<char>(skill);
            for(int j=0; j<k; j++)
            {
                char[] temp1=skill_trees[i].ToCharArray();
                if(empty.Contains(temp1[j]))//리스트 안에 있는지 검색
                {
                    if(temp1[j]==empty[0])//선행스킬을 무시하지않은경우
                    {
                        Console.Write(empty[0]);
                        empty.Remove(empty[0]);
                    }
                    else //선행스킬을 무시한경우 
                        break;
                }
                if(j==k-1) answer++;
            }
        }
        return answer;
    }
}