/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node(){}
    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
}
        4

    2       5

1       3
left = 1
right = 3

*/
public class Solution {
    public Node TreeToDoublyList(Node root) {
        if(root==null)
        {
            return null;
        }
        Node left = TreeToDoublyList(root.left);
        Node right = TreeToDoublyList(root.right);
        
        root.left = root;
        root.right = root;

        Node n = Concatnate(left,root);
        n = Concatnate(n,right); 
        return n;
    }

    private Node Concatnate(Node leftNode, Node rightNode)
    {
        if(leftNode==null)
        {
            return rightNode;
        }
        if(rightNode==null)
        {
            return leftNode;
        }

        Node leftEnd = leftNode.left;
        Node rightEnd = rightNode.left;

        leftNode.left = rightEnd;
        rightEnd.right = leftNode;

        leftEnd.right = rightNode;
        rightNode.left = leftEnd;
        return leftNode;
    }
}