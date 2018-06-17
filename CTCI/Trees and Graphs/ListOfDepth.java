/*
4.3 List of Depths: Given a binary tree, design an algorithm which creates a linked list of all the nodes
at each depth (e.g., if you have a tree with depth 0, you'll have 0 linked lists).
Hints: #107, #123, #735
*/

class Wrapper {
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     int val;
     *     TreeNode left;
     *     TreeNode right;
     *     TreeNode(int x) { val = x; }
     * }
     */
    
    public static String treeNodeToString(TreeNode root) {
        if (root == null) {
            return "[]";
        }
    
        String output = "";
        Queue<TreeNode> nodeQueue = new LinkedList<>();
        nodeQueue.add(root);
        while(!nodeQueue.isEmpty()) {
            TreeNode node = nodeQueue.remove();
    
            if (node == null) {
              output += "null, ";
              continue;
            }
    
            output += String.valueOf(node.val) + ", ";
            nodeQueue.add(node.left);
            nodeQueue.add(node.right);
        }
        return "[" + output.substring(0, output.length() - 2) + "]";
    }
    
    public static TreeNode stringToTreeNode(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        if (input.length() == 0) {
            return null;
        }
    
        String[] parts = input.split(",");
        String item = parts[0];
        TreeNode root = new TreeNode(Integer.parseInt(item));
        Queue<TreeNode> nodeQueue = new LinkedList<>();
        nodeQueue.add(root);
    
        int index = 1;
        while(!nodeQueue.isEmpty()) {
            TreeNode node = nodeQueue.remove();
    
            if (index == parts.length) {
                break;
            }
    
            item = parts[index++];
            item = item.trim();
            if (!item.equals("null")) {
                int leftNumber = Integer.parseInt(item);
                node.left = new TreeNode(leftNumber);
                nodeQueue.add(node.left);
            }
    
            if (index == parts.length) {
                break;
            }
    
            item = parts[index++];
            item = item.trim();
            if (!item.equals("null")) {
                int rightNumber = Integer.parseInt(item);
                node.right = new TreeNode(rightNumber);
                nodeQueue.add(node.right);
            }
        }
        return root;
    }
    
    public static void prettyPrintTree(TreeNode node, String prefix, boolean isLeft) {
        if (node == null) {
            System.out.println("Empty tree");
            return;
        }
    
        if (node.right != null) {
            prettyPrintTree(node.right, prefix + (isLeft ? "│   " : "    "), false);
        }
    
        System.out.println(prefix + (isLeft ? "└── " : "┌── ") + node.val);
    
        if (node.left != null) {
            prettyPrintTree(node.left, prefix + (isLeft ? "    " : "│   "), true);
        }
    }
    
    public static void prettyPrintTree(TreeNode node) {
        prettyPrintTree(node,  "", true);
    }
}

public class MainClass {
    public static void main(String[] args) throws IOException {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        String line;
        TreeNode root = null;
        while ((line = in.readLine()) != null) {
            TreeNode node = Wrapper.stringToTreeNode(line);
            root = node;
            Wrapper.prettyPrintTree(root);
        }
        MainClass mn = new MainClass();
        List<List<Integer>> result = mn.getListOfDepths(root);
        for(int i=0;i<result.size();i++)
        {
        	for(int j=0;j<result.get(i).size();j++)
        	{
        		System.out.print(result.get(i).get(j)+" ");
        	}
        	System.out.println();
        }

    }

    public List<List<Integer>> getListOfDepths(TreeNode root)
    {
    	LinkedList<TreeNode> currentList = new LinkedList<TreeNode>();
    	currentList.add(root);
    	LinkedList<TreeNode> nextList = new LinkedList<TreeNode>();
    	List<Integer> innerList = new ArrayList<Integer>();
    	List<List<Integer>> result = new ArrayList<List<Integer>>();
    	while(!currentList.isEmpty())
    	{
    		TreeNode node = currentList.remove();
    		innerList.add(node.val);
    		if(node.left!=null)
    		{
    			nextList.add(node.left);
    		}
    		if(node.right!=null)
    		{
    			nextList.add(node.right);
    		}
    		if(currentList.isEmpty())
    		{
    			currentList = nextList;
    			nextList = new LinkedList<TreeNode>();
    			result.add(innerList);
    			innerList = new ArrayList<Integer>();
    		}
    	}
    	return result;
    }

}