namespace Assignment1;

class Proram
{
    public static void Main(string[] agrs)
    {
        // 1.Two Sum
        Solution res = new Solution();
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = res.TwoSum(nums,target);
        Console.WriteLine("The output for Problem 1 is: [{0},{1}]", result[0],result[1]);

        int x = 121;
        Console.WriteLine("Problem9, the output of is {0} a Palindrome number is {1}",x,res.IsPalindrome(x));
        int y = 123;
        Console.WriteLine("Problem9, the output of is {0} a Palindrome number is {1}", y, res.IsPalindrome(y));


        int[] num1 = new int[] { 1, 2, 3, 4 };
        int[] num2 = new int[] { 1, 2, 3, 3 };
        Console.WriteLine("Problem 217, the output of if [1,2,3,4] contains duplicates is {0}", res.ContainsDuplicate(num1));
        Console.WriteLine("Problem 217, the output of if [1,2,3,3] contains duplicates is {0}", res.ContainsDuplicate(num2));

        int n = 15;
        Console.WriteLine("Question 412, the output when n = 15 is:");
        foreach (var item in res.FizzBuzz(15))
        {
            Console.Write(item + " ");
        }

    }


}

public class Solution
{
    // 1.Two Sum
    public int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> dict = new();
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                result[0] = dict[complement];
                result[1] = i;

            }
            dict[nums[i]] = i;
        }
        return result;
    }

    // 9.Palindrome Number
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var numberStr = x.ToString();
        var numberReverseStr = "";

        for (int i = numberStr.Length - 1; i >= 0; i--)
            numberReverseStr += numberStr[i];

        long numberReverse = long.Parse(numberReverseStr);



        return numberReverse == x;
    }

    // 217. Contains Duplicate
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] += 1;

            }
            else
            {
                dict[nums[i]] = 1;
            }
        }

     
        foreach (var item in dict)
        {
            if (item.Value > 1)
            {
                return true;
            }
        }
        return false;
    }

    // 412.Fizz Buzz
    public IList<string> FizzBuzz(int n)
    {
        List<string> result = new();
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if ((i + 1) % 5 == 0)
            {
                result.Add("Buzz");
            }
            else if ((i + 1) % 3 == 0)
            {
                result.Add("Fizz");
            }
            else
            {
                result.Add((i + 1).ToString());
            }
        }
        return result;
    }

}

