using System;

public class Solution 
{
    public int solution(int angle)
    {
         if (0 < angle && angle < 90)  // c#은(0 < angle < 90)안된다
         {    
             return 1;
         } 
        else if (angle == 90)
        {
            return 2;
        } 
        else if (90 < angle && angle < 180)
        {
            return 3;
        }
        else if (angle == 180)
        {
            return 4;
        }
        else
        {
            return 0;  //  모든 조건에 해당하지 않는 조건을 처리해줘야함
        }
        
    }
}