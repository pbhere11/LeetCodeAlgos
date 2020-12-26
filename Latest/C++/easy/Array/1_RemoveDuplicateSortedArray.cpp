#include <vector>
#include <iostream>

using namespace std;

class Solution
{
public:
    int removeDuplicates(vector<int> &nums)
    {
        if (nums.size() == 0)
            return 0;
        int index = 1;
        for (int i = 1; i < nums.size(); i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
};

/*
Example 1:

Input: nums = [1,1,2]
Output: 2, nums = [1,2]
Explanation: Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the returned length.
Example 2:

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4]
Explanation: Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively. It doesn't matter what values are set beyond the returned length.
 
*/
void printArray(int uniqueLength, vector<int> nums)
{
    for (int i = 0; i < uniqueLength; i++)
    {
        cout << nums[i] << " " << endl;
    }
}

int main()
{
    Solution sln;
    vector<int> nums{0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
    // vector<int> nums {1,1,2};
    int uniqueLength = sln.removeDuplicates(nums);
    printArray(uniqueLength, nums);
}