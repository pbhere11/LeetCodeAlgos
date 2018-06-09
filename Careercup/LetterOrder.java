/*
Given an alphabet where we do not know the order of the letters also do not know the number of letters. 

We are give an input list of tuples where each entry in the list gives an ordering between the 2 letters 

Determine the alphabet order. 

Ex- 
<A, B> 
<C, D> 
<C, E> 
<D, E> 
<A, C> 
<B, C> 
Order is A, B, C, D, E


*/
public class Main {
    public static void main(String[] args) {
        Main mn = new Main();
        List<List<Character>> lettersMap = new ArrayList<List<Character>>();
        List<Character> innerList = new ArrayList<Character>();
        innerList.add('A');
        innerList.add('B');
        lettersMap.add(innerList);
        innerList = new ArrayList<Character>();
        innerList.add('C');
        innerList.add('D');
		lettersMap.add(innerList);
        innerList = new ArrayList<Character>();
        innerList.add('C');
        innerList.add('E');
        lettersMap.add(innerList);
        innerList = new ArrayList<Character>();
        innerList.add('D');
        innerList.add('E');
        lettersMap.add(innerList);
        innerList = new ArrayList<Character>();
        innerList.add('A');
        innerList.add('C');
        lettersMap.add(innerList);
        innerList = new ArrayList<Character>();
        innerList.add('B');
        innerList.add('C');
        lettersMap.add(innerList);
        List<Character> chrList = mn.getLettersOrder(lettersMap);
       	for(int i=0;i<chrList.size();i++)
       	{
       		System.out.println(chrList.get(i));
       	}

    }

    public List<Character> getLettersOrder(List<List<Character>> lettersMap)
    {
    	char headChar='0';
    	HashMap<Character,List<Character>> letterOrderMap = new HashMap<Character,List<Character>>();
    	for(int i=0;i<lettersMap.size();i++)
    	{
    		if(letterOrderMap.containsKey(lettersMap.get(i).get(0)))
    		{
    			if(lettersMap.get(i).get(1)==headChar)
    			{
    				headChar = lettersMap.get(i).get(0);
    			}
    			List<Character> innerList = letterOrderMap.get(lettersMap.get(i).get(0));
    			innerList.add(lettersMap.get(i).get(1));

    		}
    		else
    		{
    			if(headChar=='0')
    			{
    				headChar = lettersMap.get(i).get(0);
    			}
    			else if(lettersMap.get(i).get(1)==headChar)
    			{
    				headChar = lettersMap.get(i).get(0);
    			}
    			List<Character> innerList = new ArrayList<Character>();
    			innerList.add(lettersMap.get(i).get(1));
    			letterOrderMap.put(lettersMap.get(i).get(0),innerList);
    		}
    	}

    	List<Character> result = new ArrayList<Character>();
    	LinkedList<Character>currentList = new LinkedList<Character>();
    	HashSet<Character> visitedSet = new HashSet<Character>();
    	currentList.add(headChar);
    	while(!currentList.isEmpty())
    	{
    		char c = currentList.remove();
    		if(!visitedSet.contains(c))
    		{
				result.add(c);
				visitedSet.add(c);
				if(letterOrderMap.containsKey(c))
				{
					List<Character> innerList = letterOrderMap.get(c);
		    		for(int i=0;i<innerList.size();i++)
		    		{
		    			currentList.add(innerList.get(i));
		    		}
				}
    		}
    	}
    	return result;
    }    
}