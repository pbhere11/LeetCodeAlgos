/*
4.7 Build Order: You are given a list of projects and a list of dependencies (which is a list of pairs of
projects, where the second project is dependent on the first project). All of a project's dependencies
must be built before the project is. Find a build order that will allow the projects to be built. If there
is no valid build order, return an error.
EXAMPLE
Input:
projects: a, b, c, d, e, f
dependencies: (a, d), (f, b), (b, d), (f, a), (d, c)
Output: f, e, a, b, d, c
Hints: #26, #47, #60, #85, # 125, # 733
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
    	Main mn = new Main();
        char[][] dependencies = {{'a', 'd'}, {'f', 'b'}, {'b', 'd'}, {'f', 'a'}, {'d', 'c'}};
        List<Character> sortedSequence =  mn.getSortedSequence(dependencies);
        for(int i=0;i<sortedSequence.size();i++)
        {
            System.out.println(sortedSequence.get(i));
        }
    }

    public List<Character> getSortedSequence(char[][] dependencies)
    {
    	char headChar = '0';
    	HashMap<Character,List<Character>> dependencyMap = new HashMap<Character,List<Character>>();
    	for(int i=0;i<dependencies.length;i++)
    	{
    		char fromDependency = dependencies[i][0];
    		char toDependency = dependencies[i][1];
    		if(headChar=='0')
    		{
    			headChar = fromDependency;
    		}
    		else if(headChar == toDependency)
    		{
    			headChar = fromDependency;
    		}

    		if(dependencyMap.containsKey(fromDependency))
    		{
    			List<Character> innerList =  dependencyMap.get(fromDependency);
    			innerList.add(toDependency);
    		}
    		else
    		{
    			List<Character> innerList =  new ArrayList<Character>();
    			innerList.add(toDependency);
    			dependencyMap.put(fromDependency,innerList);
    		}
    	}
        List<Character> result = new ArrayList<Character>();

        dfs(headChar,dependencyMap,result);
        for(Character c: dependencyMap.keySet())
        {
            if(!result.contains(c))
            {
                dfs(c,dependencyMap,result);
            }
        }
        return result;
    }

    public void dfs(Character c, HashMap<Character,List<Character>> dependencyMap, List<Character> result)
    {
        result.add(c);
        if(dependencyMap.containsKey(c))
        {
            List<Character> innerList = dependencyMap.get(c);
            for(int i=0;i<innerList.size();i++)
            {
                if(!result.contains(innerList.get(i)))
                {
                   dfs(innerList.get(i),dependencyMap,result); 
                }
            }
        }
        
    }
}