namespace TwoSum;

internal class Program
{
    static void Main(string[] args)
    {
        
    }
}
internal class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }
        return new[] { -1, -1};
    }
}
