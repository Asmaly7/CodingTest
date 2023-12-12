public class Solution 
{
    public long solution(int a, int b) 
    {
        long answer = 0;

        int smaller; // 더 작은 값을 저장할 변수

        // a가 b보다 작거나 같으면 a가 더 작은 값
        if (a <= b)
        {
            smaller = a;
        }
        // 그렇지 않으면 b가 더 작은 값
        else
        {
            smaller = b;
        }

        int larger; // 더 큰 값을 저장할 변수

        // smaller가 a와 같으면 b가 더 큰 값
        if (smaller == a)
        {
            larger = b;
        }
        // 그렇지 않으면 a가 더 큰 값
        else
        {
            larger = a;
        }

        // 더 작은 값부터 더 큰 값까지의 모든 정수를 더합니다.
        for (int i = smaller; i <= larger; i++)
        {
            answer += i;
        }

        return answer;
    }
}