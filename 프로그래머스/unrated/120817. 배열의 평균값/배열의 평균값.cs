using System;

public class Solution 
{
    public double solution(int[] numbers)
    {
        double sum = 0;
        
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        double average = sum / numbers.Length;
        return average;
    }
}