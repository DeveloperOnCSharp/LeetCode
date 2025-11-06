namespace Median_of_Two_Sorted_Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = {1, 2, 5, 6, 12};
        int[] nums2 = {3, 4, 7, 8};
        int[] newArray = new int[nums1.Length + nums2.Length];
        
        FindMedianSortedArrays(nums1, nums2, ref newArray, 0, 0, 0);
        //TODO: завершить алгоритм
        // if( newArray.Length == 1 )
        //     Console.WriteLine(newArray[0]);
        // if(newArray.Length == 2 ) 
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2, ref int[] newArray,
        int i, int j, int counter)
    {
        // Базовый вариант [0] [0]
        if (i >= nums1.Length && j >= nums2.Length)
            return 0;
        
        // Первый вариант [0] && [n1, ...]
        if(i >= nums1.Length)
        {
            newArray[counter] = nums2[j];
            counter++;
            j++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter);
        }
        // Второй вариант [n1, ...] && [0]
        if(j >= nums2.Length)
        {
            newArray[counter] = nums1[i];
            counter++;
            i++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter);
        }
        // Третий вариант [n1,n2] && [m1, m2]
        if (nums1[i] <= nums2[j])
        {
            newArray[counter] = nums1[i];
            counter++;
            i++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter);
        }
        else
        {
            newArray[counter] = nums2[j];
            counter++;
            j++;
            return FindMedianSortedArrays(nums1, nums2, ref newArray, i, j, counter);
        }
    }
}


