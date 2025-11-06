namespace Median_of_Two_Sorted_Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = {1, 2};
        int[] nums2 = {3, 4};
        int[] newArray = new int[nums1.Length + nums2.Length];
        double result = 0;

        Console.WriteLine(FindMedianSortedArrays(nums1, nums2, ref newArray, 0, 0, 0, result));
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2, ref int[] newArray,
        int i, int j, int counter, double x)
    {
        // Базовый вариант [0] [0]
        if (i >= nums1.Length && j >= nums2.Length)
        {
            if (newArray.Length == 0)
                return 0;
            if (newArray.Length == 1)
                return newArray[0];
            if (newArray.Length % 2 != 0)
                return newArray[newArray.Length / 2];
            if(newArray.Length % 2 == 0)
                return x = (double)(newArray[newArray.Length/2] + newArray[newArray.Length/2-1]) / 2;
        }
        
        // Первый вариант [0] && [n1, ...]
        if(i >= nums1.Length)
        {
            newArray[counter] = nums2[j];
            counter++;
            j++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter,x);
        }
        // Второй вариант [n1, ...] && [0]
        if(j >= nums2.Length)
        {
            newArray[counter] = nums1[i];
            counter++;
            i++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter,x);
        }
        // Третий вариант [n1,n2] && [m1, m2]
        if (nums1[i] <= nums2[j])
        {
            newArray[counter] = nums1[i];
            counter++;
            i++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter,x);
        }
        else
        {
            newArray[counter] = nums2[j];
            counter++;
            j++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter,x);
        }
    }
    
}


