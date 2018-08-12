/*
Follow up:
Could you do both operations in O(1) time complexity?

Example:

LRUCache cache = new LRUCache( 2 /* capacity  );

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.put(4, 4);    // evicts key 1
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4
*/
public class LRUCache {
	public class ListNode{
		public int key;
		public int val;
		public ListNode prev;
		public ListNode next;
		public ListNode(int key, int val)
		{
			this.key = key;
			this.val = val;
		}
	}
	private int capacity;
	private Dictionary<int,ListNode> map = new Dictionary<int,ListNode>();
	ListNode head = null;
	ListNode tail = null;
    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key))
        {
        	ListNode oldNode = map[key];
        	ListNode node = new ListNode(key,oldNode.val);
        	Remove(oldNode);
        	SetHead(node);
        	map.Add(key,node);
        	return map[key].val;
        }
        else
        {
        	return -1;
        }
    }
    
    public void Put(int key, int value) {
    	ListNode node = new ListNode(key,value);
        if(!map.ContainsKey(key))
        {
        	if(map.Count>=capacity)
        	{
        		Remove(tail);
        	}
        	SetHead(node);
        }
        else
        {
        	ListNode oldNode = map[key];
        	Remove(oldNode);
        	SetHead(node);
        }
        map.Add(key,node);
    }

    private void SetHead(ListNode node)
    {
    	if(head==null)
    	{
    		head = node;
    		if(tail==null)
    		{
    			tail = head;
    		}
    	}
    	else
    	{
    		node.next = head;
    		head.prev = node;
    		head = node;
    	}
    }

    private void Remove(ListNode node)
    {
    	if(node!=null)
    	{
    		if(node.prev!=null)
    		{
    			node.prev.next = node.next;
    		}
    		else
    		{
    			head = node.next;
    		}
    		if(node.next!=null)
    		{
    			node.next.prev = node.prev;
    		}
    		else
    		{
    			tail = node.prev;
    		}

    		map.Remove(node.key);
    	}
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */