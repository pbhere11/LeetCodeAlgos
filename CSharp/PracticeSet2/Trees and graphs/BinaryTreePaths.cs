/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
 */
public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
      IList<string> result = new List<string>();
      Helper(root,result,"");  
      return result;
    }
    private void Helper(TreeNode root, IList<string> result, string resultStr)
    {
    	if(root!=null)
    	{
    		if(root.left==null&&root.right==null)
    		{
    			string nextStr = "";
		    	if(resultStr.Length==0)
		    	{
		    		nextStr = root.val.ToString();
		    	}
		    	else
		    	{
		    		nextStr = resultStr+"->"+root.val.ToString();
		    	}
    			result.Add(nextStr);
    		}
    		else
    		{
    			string nextStr = "";
		    	if(resultStr.Length==0)
		    	{
		    		nextStr = root.val.ToString();
		    	}
		    	else
		    	{
		    		nextStr = resultStr+"->"+root.val.ToString();
		    	}
		    	Helper(root.left,result,nextStr);
		    	Helper(root.right,result,nextStr);
    		}
    	}
    }
}