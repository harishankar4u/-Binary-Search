class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(binarySearch([1,2,5,6,7,9],2));  //output
        Console.WriteLine(binarySearch([1, 2, 5, 6, 7, 9], 7));
    }
    public static int binarySearch(int[] nums,int target)
    {
        int left = 0;
        int right = nums.Length-1;
        while (left <= right)
        {
            int mid=(left+right)/2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid;
                //left++;
                //
                //right--;
            }
        }
        return left;

    }
}