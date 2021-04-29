using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        char[] input = dirs.ToCharArray();
        int[,,,] road = new int[11,11,11,11]; //그래프의 가로 간선
        int curX = 5;
        int curY = 5;
        for(int i=0; i<input.Length; i++)
        {
            int startX = curX; // 현재 간선에서의 출발 정점 X좌표
            int startY = curY; // 현재 간선에서의 출발 정점 Y좌표
            if(input[i]=='U')
            {
                if (curY + 1 > 10) // 무시
                    continue;
                curY++;
            }
            if(input[i]=='D')
            {
                if (curY -1< 0) // 무시
                    continue;
                curY--;
            }
            if(input[i]=='R')
            {
                if (curX +1 > 10) // 무시
                    continue;
                curX++;
            }
            if(input[i]=='L')
            {
                if (curX -1< 0) // 무시
                    continue;   
                curX--;
            }
            
            // 출발정점,도착정점 둘 다 방문한적 있다면 무시(양방향탐색)
            if (road[startX,startY,curX,curY] == 1
                ||road[curX,curY,startX,startY]==1)  
                continue;
            // 출발정점,도착정점 true(1)로 방문 체크 (양방향으로)
             road[startX,startY,curX,curY]=1;
             road[curX,curY,startX,startY]=1;
             answer++; 
        }
        return answer;
    }
}