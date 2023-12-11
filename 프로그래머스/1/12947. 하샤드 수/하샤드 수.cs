public class Solution 
{
    public bool solution(int x) 
    {
       int originalNum = x;
        int sumOfDigits = 0;

        // 자릿수 합 구하기
        while (x > 0) 
        {
            sumOfDigits += x % 10; // 각 자릿수 더하기
            x /= 10; // 다음 자릿수로 이동
        }

        // 하샤드 수 판별
        if (originalNum % sumOfDigits == 0) 
        {
            return true; // 하샤드 수인 경우
        } 
        else 
        {
            return false; // 하샤드 수가 아닌 경우
        }
    }
}