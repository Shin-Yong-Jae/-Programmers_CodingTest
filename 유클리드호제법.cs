public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int a =n;
        int b =m;
        int temp=0;
        while(m>0)
        {
            temp =n%m;
            n=m;
            m=temp;
        }
        answer[0]=n;
        answer[1]=a*b/n;
        return answer;
    }
}