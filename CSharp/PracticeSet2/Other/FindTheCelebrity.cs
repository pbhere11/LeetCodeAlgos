/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) {
        int celeb = 0;
        for(int i=1;i<n;i++)
        {
        	if(base.Knows(celeb,i))
        	{
        		celeb = i;
        	}
        }
        for(int i=0;i<n;i++)
        {
        	if(i!=celeb && (base.Knows(celeb,i) || !base.Knows(i,celeb)))
        	{
        		return -1;
        	}
        }
        return celeb;
    }
}