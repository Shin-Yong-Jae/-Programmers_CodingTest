public class Solution {
    public string solution(string s) {
        char[] temp = s.ToCharArray();
        int checker =0;
        for(int i=0; i<temp.Length; i++)
        {
            if(temp[i]==' ')
            {
                checker =0;
                continue;
            }
            else if(checker%2==0)
            {
                temp[i]=char.ToUpper(temp[i]);
            }
            else 
            {
                temp[i]=char.ToLower(temp[i]);
            }
            checker++;
        }
        string answer =new string(temp);
        return answer;
    }
}