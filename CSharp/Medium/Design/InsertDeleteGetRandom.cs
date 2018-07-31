/*
Example:

// Init an empty set.
RandomizedSet randomSet = new RandomizedSet();

// Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomSet.insert(1);

// Returns false as 2 does not exist in the set.
randomSet.remove(2);

// Inserts 2 to the set, returns true. Set now contains [1,2].
randomSet.insert(2);

// getRandom should return either 1 or 2 randomly.
randomSet.getRandom();

// Removes 1 from the set, returns true. Set now contains [2].
randomSet.remove(1);

// 2 was already in the set, so return false.
randomSet.insert(2);

// Since 2 is the only number in the set, getRandom always return 2.
randomSet.getRandom();
*/

public class RandomizedSet {

    Dictionary<int,int> map1 = new Dictionary<int,int>();
    Dictionary<int,int> map2 = new Dictionary<int,int>();
    Random rnd = new Random();
    /** Initialize your data structure here. */
    public RandomizedSet() {
        
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(map1.ContainsKey(val))
        {
            return false;
        }
        else
        {
            map1.Add(val,map2.Count);
            map2.Add(map2.Count,val);
            return true;
        }
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(!map1.ContainsKey(val))
        {
            return false;
        }
        else
        {
            int index = map1[val];
            map1.Remove(val);
            map2.Remove(index);
            if(map2.Count==0)
            {
                return true;
            }
            if(index==map2.Count)
            {
                return true;
            }
            int newVal = map2[map2.Count];
            map2.Add(index,newVal);
            map2.Remove(map2.Count);
            map1[newVal] = index;
            return true;
        }
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        int index = rnd.Next(map2.Count);
        return map2[index];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */