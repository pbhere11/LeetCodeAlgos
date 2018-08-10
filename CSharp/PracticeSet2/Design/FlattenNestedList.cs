/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 Example 1:

Input: [[1,1],2,[1,1]]
Output: [1,1,2,1,1]
Explanation: By calling next repeatedly until hasNext returns false, 
             the order of elements returned by next should be: [1,1,2,1,1].
Example 2:

Input: [1,[4,[6]]]
Output: [1,4,6]
Explanation: By calling next repeatedly until hasNext returns false, 
             the order of elements returned by next should be: [1,4,6].
 */
public class NestedIterator {
	Stack<NestedInteger> stack = new Stack<NestedInteger>();
    public NestedIterator(IList<NestedInteger> nestedList) {
        if(nestedList!=null)
        {
        	for(int i=nestedList.Count-1;i>=0;i--)
        	{
        		stack.Push(nestedList[i]);
        	}
        }
    }

    public bool HasNext() {
       while(stack.Count>0)
       {
       		NestedInteger top = stack.Peek();
       		if(top.IsInteger())
       		{
       			return true;
       		}
       		else
       		{
       			stack.Pop();
       			for(int i=top.GetList().Count-1;i>=0;i--)
       			{
       				stack.Push(top.GetList()[i]);
       			}
       		}
       } 
       return false;
    }

    public int Next() {
        return stack.Pop().GetInteger();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */