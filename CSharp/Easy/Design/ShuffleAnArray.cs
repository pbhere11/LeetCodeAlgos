/*
Example:

// Init an array with set 1, 2, and 3.
int[] nums = {1,2,3};
Solution solution = new Solution(nums);

// Shuffle the array [1,2,3] and return its result. Any permutation of [1,2,3] must equally likely to be returned.
solution.shuffle();

// Resets the array back to its original configuration [1,2,3].
solution.reset();

// Returns the random shuffling of array [1,2,3].
solution.shuffle();
*/
public class Solution {
	private int[] original;
	private int[] array;
	private Random rnd;
    public Solution(int[] nums) {
        array = nums;
        original = (int[])nums.Clone();
        rnd = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        array = original;
        original = (int[])original.Clone();
        return array;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for(int i=0;i<array.Length;i++)
        {
        	Swap(array,i,GetRandomIndex(i,array.Length));
        }
        return array;
    }

    private int GetRandomIndex(int min, int max)
    {
    	return rnd.Next(max-min)+min;
    }

    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */