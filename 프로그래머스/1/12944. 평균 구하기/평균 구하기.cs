public class Solution 
{
    public double solution(int[] arr) 
    {
         int sum = 0;
        
        foreach(int num in arr)
        {
            sum += num;
        }    
        
        double average = (double)sum / arr.Length;
        
        return average;      
            
    }
}