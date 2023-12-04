public class Solution 
{
    public long[] solution(int x, int n) 
    {
        long[] answer = new long[n]; // n의 길이로 배열 초기화

        for (int i = 0; i < n; i++)
        {
            answer[i] = (long)x * (i + 1); // x부터 시작하여 x씩 증가한 값을 할당
        }

        return answer;
    }
}