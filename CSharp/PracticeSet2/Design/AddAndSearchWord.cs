/*
Example:

addWord("bad")
addWord("dad")
addWord("mad")
search("pad") -> false
search("bad") -> true
search(".ad") -> true
search("b..") -> true
*/
public class WordDictionary {
	public class TrieNode{
		public char c;
		public TrieNode()
		{

		}
		public TrieNode(char c)
		{
			this.c = c;
		}
		public Dictionary<char,TrieNode> children = new Dictionary<char,TrieNode>();
		public bool isLeaf = false;
	}
	private TrieNode root;
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
    	Dictionary<char,TrieNode> children = root.children; 
        for(int i=0;i<word.Length;i++)
        {
        	TrieNode t = null;
        	if(!children.ContainsKey(word[i]))
        	{
        		t = new TrieNode(word[i]);
        		children.Add(word[i],t);
        	}
        	else
        	{
        		t =  children[word[i]];
        	}
        	children = t.children;
        	if(i==word.Length-1)
        	{
        		t.isLeaf = true;
        	}
        }
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        return DFS(word,0,root.children);
    }
    private bool DFS(string word, int index, Dictionary<char,TrieNode> children)
    {
    	if(index==word.Length)
    	{
    		return children.Count==0;
    	}
    	char c = word[index];
    	if(c!='.' && children.ContainsKey(c))
    	{
    		TrieNode t = children[c];
    		if(index==word.Length-1 && t.isLeaf)
    		{
    			return true;
    		}
    		return DFS(word,index+1,t.children);
    	}
    	else if(c=='.')
    	{
    		foreach(KeyValuePair<char,TrieNode> item in children)
    		{
    			if(index==word.Length-1 && item.Value.isLeaf)
	    		{
	    			return true;
	    		}
    			bool flag = DFS(word,index+1,item.Value.children);
    			if(flag)
    			{
    				return flag;
    			}
    		}
    		return false;
    	}
    	else
    	{
    		return false;
    	}
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */