/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
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
 */
class Solution {
    public List<List<Integer>> verticalOrder(TreeNode root) {
        HashMap<Integer,List<Integer>> columnMap = new HashMap<Integer,List<Integer>>();
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root==null)
        {
            return result;
        }
        LinkedList<TreeNode> currentList = new LinkedList<TreeNode>();
        LinkedList<TreeNode> nextList = new LinkedList<TreeNode>();
        LinkedList<Integer> innerList = new LinkedList<Integer>();
        LinkedList<Integer> currentIndexList = new LinkedList<Integer>();
        int minIndex =0;
        int maxIndex =0;
        currentList.add(root);
        currentIndexList.add(0);
        while(!currentList.isEmpty())
        {
            TreeNode node = currentList.remove();
            int columnIndex = currentIndexList.remove();
            if(!columnMap.containsKey(columnIndex))
            {
                List<Integer> list = new ArrayList<Integer>();
                list.add(node.val);
                columnMap.put(columnIndex,list);
            }
            else
            {
                List<Integer> list = columnMap.get(columnIndex);
                list.add(node.val);
            }
            minIndex = Math.min(minIndex,columnIndex);
            maxIndex = Math.max(maxIndex,columnIndex);
            if(node.left!=null)
            {
                nextList.add(node.left);
                innerList.add(columnIndex-1);
            }
            if(node.right!=null)
            {
                nextList.add(node.right);
                innerList.add(columnIndex+1);
            }
            if(currentList.isEmpty())
            {
                currentList = nextList;
                currentIndexList = innerList;
                nextList = new LinkedList<TreeNode>();
                innerList = new LinkedList<Integer>();
            }
        }
        for(int i=minIndex;i<=maxIndex;i++)
        {
            result.add(columnMap.get(i));
        }
        return result;
    }
}