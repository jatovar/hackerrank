class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var orderedList = arr.OrderBy(x => x);
        long sumMax = orderedList.Skip(1).Sum(item => (long)item);
        long sumMin = orderedList.SkipLast(1).Sum(item => (long)item);

        Console.Write($"{sumMin} {sumMax}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
