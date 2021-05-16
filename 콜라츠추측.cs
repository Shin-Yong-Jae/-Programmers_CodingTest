public class Solution {
    public int solution(long num) {
        int answer = 0;
        while(num>=0)
        {
            if(num==1){
                break;
            }
            else if(answer >=500)
            {
                answer = -1;
                break;
            }
            else if(num%2==0)
            {
                num/=2;
                answer++;
            }
            else if(num%2==1)
            {
                num *=3;
                num++;
                answer++;
            }
            
        }
        return answer;
    }
}