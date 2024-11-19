using System;
using System.Collections;

public class GFG{
	static public void Main ()
	{
	    //max value Taro Course;
		int[] nums = {1,2,3,4,5,6,7,8,9,-1,-2,-3,-4};
		var maxValue = GetMaxValue(nums);
		Console.WriteLine($"Max Value is {maxValue}");
	}
	
	public static int GetMaxValue(int[] nums)
	{
	    var maxval = Int32.MinValue;
	    if(nums.Length == 0){ 
	        return maxval;
	    }
	    foreach(var num in nums){
	        if (num > maxval)
	        {
	            maxval = num;
	        }
	    }
	    return maxval;
	}
}
