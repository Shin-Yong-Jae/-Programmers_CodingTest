public class Solution {
    public string solution(string s) {
        char[] temp = s.ToLower().ToCharArray();
        int result;
        for(int i=0; i<temp.Length; i++)
        {
            if(!int.TryParse(temp[0].ToString(), out result))
            {
                temp[0]=char.ToUpper(temp[0]);
            }
            if(temp[i]==' '&&i<temp.Length-1)
            {
                temp[i+1]=char.ToUpper(temp[i+1]);
            }
        }
        string answer =new string(temp);
        return answer;
    }
}