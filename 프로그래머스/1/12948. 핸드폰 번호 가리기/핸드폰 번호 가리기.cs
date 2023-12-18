public class Solution 
{
    public string solution(string phone_number) 
    {
         char[] phoneChars = phone_number.ToCharArray(); 
        
        for (int i = 0; i < phoneChars.Length - 4; i++)
        {
            phoneChars[i] = '*';
        }

        return new string(phoneChars); 
    }
}