/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
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
class Solution {
    private int heapSize =0;
    public ListNode mergeKLists(ListNode[] lists) {
    	if(lists.length==0)
    	{
    		return null;
    	}
        heapSize = lists.length;
        buildHeap(lists);
        ListNode head = null;
        ListNode node = lists[0];
        ListNode returnHead = null;
        while(heapSize!=0)
        {	
        	if(node!=null)
        	{
        		if(head==null)
	        	{
	        		head=node;
	        		returnHead = head;
	        	}
	        	else
	        	{
	        		head.next = node;
	        		head = head.next;
	        	}
        		node=node.next;
        	}
        	
        	if(node==null)
        	{
        		lists[0] = lists[heapSize-1];
        		heapSize--;
        	}
        	else
        	{
        		lists[0] = node;
        	}
        	minHeapify(lists,0);
        	node = lists[0];
        }
        return returnHead;
    }

    private void buildHeap(ListNode[] lists)
    {
    	for(int i=lists.length/2;i>=0;i--)
    	{
    		minHeapify(lists,i);
    	}
    }
    private void minHeapify(ListNode[] lists, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	if(left < heapSize && ((lists[index]==null && lists[left]!=null)||(lists[left]!=null && lists[left].val<lists[index].val)))
    	{
    		min = left;
    	}
    	if(right < heapSize && ((lists[min]==null && lists[right]!=null)||(lists[right]!=null && lists[right].val<lists[min].val)))
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		ListNode node = lists[min];
    		lists[min] = lists[index];
    		lists[index] = node;
    		minHeapify(lists,min);
    	}
    }
}