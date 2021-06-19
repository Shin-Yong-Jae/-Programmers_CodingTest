using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 1;
        Stack<int> node = new Stack<int>();
        HashSet<int> unvisited =new HashSet<int>();
        //아직 탐색 전에 모든 노드는 비 방문 상태.
        for(int i=0; i<n; i++) unvisited.Add(i);
        node.Push(0);
        while(unvisited.Count > 0)
        {
            if(node.Count ==0)
            {
                foreach(var i in unvisited)
                {
                    node.Push(i);
                    answer++;
                    break;
                }
            }
            int currentnode = node.Pop();
            unvisited.Remove(currentnode);
            for(int i=0; i<n; i++)
            {
                //만약 노드 자기 자신 값이면 패스
                if(i==currentnode) continue;
                //만약 i노드가 unvisted가 아니라면 패스
                if(!unvisited.Contains(i)) continue;
                //자식 노드 푸쉬
                if(computers[currentnode,i]==1) node.Push(i);
            }
        }
        return answer;
    }
}