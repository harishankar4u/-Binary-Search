class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(BinarySearch(new int[] { 1, 2, 5, 6, 7, 9 }, 2)); // 1
        Console.WriteLine(BinarySearch(new int[] { 1, 2, 5, 6, 7, 9 }, 7)); // 4
        Console.WriteLine(BinarySearch(new int[] { 1, 2, 5, 6, 7, 9 }, 4)); // -1
    }
    public static int BinarySearch(int[] nums,int target)
    {
        int left = 0;
        int right = nums.Length-1;
        while (left <= right)
        {
            int mid=left+(right-left)/2; // it will not failed with large value
           // int mid=(right+left)/2;  this approach is failed with large value
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] > target)
            {
                right = mid-1;
            }
            else
            {
                left = mid+1;
                //left++;
                //
                //right--;
            }
        }
        return -1;

    }
}