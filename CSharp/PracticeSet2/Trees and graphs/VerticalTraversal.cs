/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 Examples 1:

Input: [3,9,20,null,null,15,7]

   3
  /\
 /  \
 9  20
    /\
   /  \
  15   7 

Output:

[
  [9],
  [3,15],
  [20],
  [7]
]
Examples 2:

Input: [3,9,8,4,0,1,7]

     3
    /\
   /  \
   9   8
  /\  /\
 /  \/  \
 4  01   7 

Output:

[
  [4],
  [9],
  [3,0,1],
  [8],
  [7]
]
Examples 3:

Input: [3,9,8,4,0,1,7,null,null,null,2,5] (0's right child is 2 and 1's left child is 5)

     3
    /\
   /  \
   9   8
  /\  /\
 /  \/  \
 4  01   7
    /\
   /  \
   5   2

Output:

[
  [4],
  [9,5],
  [3,0,1],
  [8,2],
  [7]
]
 */
public class Solution {
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        Queue<TreeNode> currentList = new Queue<TreeNode>();
        Queue<int> indexList = new Queue<int>();
        Dictionary<int,IList<int>> map = new Dictionary<int,IList<int>>();
        IList<IList<int>> result = new List<IList<int>>();
        int min =0;
        int max =0;

        int currentCount =0;
        int nextCount =0;
        if(root!=null)
        {
        	currentList.Enqueue(root);
        	indexList.Enqueue(0);
        	currentCount = 1;
        }
        else
        {
        	return result;
        }
        while(currentCount>0)
        {
        	TreeNode node = currentList.Dequeue();
        	int index = indexList.Dequeue();
        	if(map.ContainsKey(index))
        	{
        		map[index].Add(node.val);
        	}
        	else
        	{
        		IList<int> innerList = new List<int>();
        		innerList.Add(node.val);
        		map.Add(index,innerList);
        	}
        	min = Math.Min(min,index);
        	max = Math.Max(max,index);
        	currentCount--;
        	if(node.left!=null)
        	{
        		currentList.Enqueue(node.left);
        		indexList.Enqueue(index-1);
        		nextCount++;
        	}
        	if(node.right!=null)
        	{
        		currentList.Enqueue(node.right);
        		indexList.Enqueue(index+1);
        		nextCount++;
        	}
        	if(currentCount==0)
        	{
        		currentCount = nextCount;
        		nextCount =0;
        	}
        }
        
        for(int i=min;i<=max;i++)
        {	
        	result.Add(map[i]);
        }
        return result;
    }
}