using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location)
    {
        int answer = 0;
        Queue<KeyValuePair<int, int>> que = new Queue<KeyValuePair<int, int>>();
        
        for(int i = 0; i < priorities.Length; i++)
        {
            que.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
        }
        
        while(true)
        {
            int Max = que.Max(x=>x.Value);
            var deque = que.Dequeue();
            if (deque.Value == Max)
            {
                if (deque.Key == location) return answer + 1;
                else
                {
                    answer++;
                    continue;
                }
            }
            que.Enqueue(deque);
        }
    }
}