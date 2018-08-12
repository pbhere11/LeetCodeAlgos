// "static void main" must be defined in a public class.
/*
Input: 
The input to the function/method consists of two arguments - 
literatureText: a string representing the block of text, 
wordsToExclude: a list of strings representing the commonly used words to be excluded while analyzing the word frequency. 

Output: 
Return a list of strings representing the most frequently used word in the text or in case of a tie, all of the most frequently 
used words in the text. 

Note: 
Words that have a different case are counted as the same word. The order of words does not matter in the output list. 
All words in the 'wordsToExclude' list are unique. Punctuation should be treated as white space. 

Example 

Input: 
literature Text = "Jack and Jill went to the market to buy bread and cheese. Cheese is Jack's and Jill's favorite food." 
wordsToExclude = ["and", "he", "the", "to", "is". "Jack", "Jill"] 

Output: ["cheese", "s"] 

Explanation: The word `and" has a maximum of three frequency but this word should be excluded while analyzing the word frequency. 
The words "Jack'. 'Jill", "s", "to" and "cheese" have the next maximum frequency(two) in the given text but the words "Jack", 
"to" and "Jill' should be excluded as these are commonly used words which you are not interested to include. 

So the output is ["cheese", `s"] or ["s", "cheese"] as the order of words does not matter.
*/
public class Main {
    public static void main(String[] args) {
        Main mn = new Main();
        String literatureText = "Jack and Jill went to the market to buy bread and cheese. Cheese is Jack's and Jill's favorite food.";
        List<String> wordsToExclude = new ArrayList<String>();
        wordsToExclude.add("and");
        wordsToExclude.add("he");
        wordsToExclude.add("the");
        wordsToExclude.add("to");
        wordsToExclude.add("is");
        wordsToExclude.add("Jack");
        wordsToExclude.add("Jill");
        List<String> result = mn.mostFrequentlyUserWords(literatureText,wordsToExclude);
        for(int i=0;i<result.size();i++)
        {
        	System.out.println(result.get(i));
        }
    }

    public List<String> mostFrequentlyUserWords(String literatureText, List<String> wordsToExclude)
    {
    	List<String> result = new ArrayList<String>();
    	literatureText = literatureText.replaceAll("[^a-zA-Z0-9]"," ");
    	String[] wordList = literatureText.split(" ");
    	HashMap<String,Integer> wordCountMap = new HashMap<String,Integer>();
    	int max =0;
    	for(int i=0;i<wordList.length;i++)
    	{
    		if(!wordsToExclude.contains(wordList[i]))
    		{
    			if(wordCountMap.containsKey(wordList[i].toLowerCase()))
    			{
    				wordCountMap.put(wordList[i].toLowerCase(),wordCountMap.get(wordList[i].toLowerCase())+1);
    				max = Math.max(max,wordCountMap.get(wordList[i].toLowerCase()));
    			}
    			else
    			{
    				wordCountMap.put(wordList[i].toLowerCase(),1);
    				max = Math.max(max,1);
    			}
    		}
    	}
    	for(String word: wordCountMap.keySet())
    	{
    		if(wordCountMap.get(word)==max)
    		{
    			result.add(word);
    		}
    	}
    	return result;
    }
}