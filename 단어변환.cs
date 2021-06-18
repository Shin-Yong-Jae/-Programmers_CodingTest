using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string begin, string target, string[] words) {
        List<string> wordstemp = new List<string>(words);
        wordstemp.Insert(0,begin); //begin 값을 첫번째 인덱스에 넣어줌.
        if(!wordstemp.Contains(target)) return 0; //만약 리스트 안에 타겟이 없다면
        
        Queue<string> BFSQueue = new Queue<string>(); //word Queue
        Queue<int> depth = new Queue<int>();          //depth Queue
        HashSet<string> visted = new HashSet<string>(); //방문여부 Set
        
        BFSQueue.Enqueue(begin); //루트 노드 설정
        depth.Enqueue(0);        //루트 노드 설정
        while(BFSQueue.Count > 0)
        {
            string currentword = BFSQueue.Dequeue();
            int currentdepth = depth.Dequeue();
            visted.Add(currentword);
            if(currentword.Equals(target)) return currentdepth; //타겟 도출시 depth
            for(int i=0; i<wordstemp.Count; i++)
            {
                if(currentword == wordstemp[i]) continue;
                if(visted.Contains(wordstemp[i])) continue;
                if(compareword(currentword,wordstemp[i]))
                {
                    BFSQueue.Enqueue(wordstemp[i]);
                    depth.Enqueue(currentdepth+1);
                }
            }
        }
        return 0;
    }
    public bool compareword(string a,string b) //문자 비교
    {
        char[] atem = a.ToCharArray();
        char[] btem = b.ToCharArray();
        int wrong =0;
        
        for(int i=0; i<atem.Length; i++)
        {
            if(atem[i] != btem[i]) wrong++;
            if(wrong>1) return false;
        }
        return true;
    }
}