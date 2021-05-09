using System;
using System.Collections.Generic;

class Solution {
    int n = 0;
    int m = 0;
    int[] dx = { -1, 1, 0, 0 };
    int[] dy = { 0, 0, -1, 1 };
    Queue<(int, int)> que = new Queue<(int, int)>();

    public void bfs(int i,int j,int[,] arr)
    {
        que.Enqueue((i, j));
        while (que.Count != 0)
        {
            (int a, int b) = que.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                int x = a + dx[k];
                int y = b + dy[k];
                if ((0<= x&& x< n)&& (0<=y&&y<m)&&(arr[x,y] == 1))
                {
                    que.Enqueue((x, y));
                    arr[x, y] = arr[a, b] + 1;
                }
            }
        }
    }
    public int solution(int[,] arr)
    {
        n = arr.GetLength(0);
        m = arr.GetLength(1);

        bfs(0, 0,arr);

        if (arr[n-1,m-1] == 1)
        {
            return -1;
        }
        else
        {
            return (arr[n - 1, m - 1]);
        }

    }
}