using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        
        while (n > 0)
        {
            answer += n % 10;  // 현재 자릿수를 변수에 더해서저장
            n /= 10;        // 다음 자릿수로 이동 반복
        }

        return answer;
    }
}