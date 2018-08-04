/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 Example:

Input:
[
  1->4->5,
  1->3->4,
  2->6
]
Output: 1->1->2->3->4->4->5->6
 */
public class Solution {
	private int HeapSize = 0;
    public ListNode MergeKLists(ListNode[] lists) {
    	if(lists.Length==0)
    	{
    		return null;
    	}
        HeapSize = lists.Length;
        int start =0;
        for(int i=0;i<lists.Length;i++)
        {
        	if(lists[i]!=null)
        	{
        		Swap(lists,i,start);
        		start++;
        	}
        	else
        	{
        		HeapSize--;
        	}
        }
        BuildHeap(lists);
        ListNode l3 = new ListNode(-1);
        ListNode head = l3;
        while(HeapSize!=0)
        {
        	ListNode node = lists[0];
        	if(lists[0].next!=null)
        	{
        		lists[0] = lists[0].next;
        	}
        	else
        	{
        		lists[0] = lists[HeapSize-1];
        		HeapSize--;
        	}
        	l3.next = node;
        	l3 = l3.next;
        	MinHeapify(lists,0);
        }
        return head.next;
    }
    private void BuildHeap(ListNode[] lists)
    {
    	for(int i=lists.Length/2;i>=0;i--)
    	{
    		MinHeapify(lists,i);
    	}
    }
    private void MinHeapify(ListNode[] lists, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	if(left<HeapSize && lists[left].val<lists[index].val)
    	{
    		min = left;
    	}
    	if(right<HeapSize && lists[right].val<lists[min].val)
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		Swap(lists,min,index);
    		MinHeapify(lists,min);
    	}
    }
    private void Swap(ListNode[] lists, int i, int j)
    {
    	ListNode temp = lists[i];
    	lists[i] = lists[j];
    	lists[j] = temp;
    }
}