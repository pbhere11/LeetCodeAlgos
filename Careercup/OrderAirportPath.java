/*
Write a method that can take in an unordered list of airport pairs visited during a trip, and return the list in order: 

Unordered: ("ITO", "KOA"), ("ANC", "SEA"), ("LGA", "CDG"), ("KOA", "LGA"), ("PDX", "ITO"), ("SEA", "PDX") 
Ordered: ("ANC", "SEA"), ("SEA", "PDX"), ("PDX", "ITO"), ("ITO", "KOA"), ("KOA", "LGA"), ("LGA", "CDG")


*/
public class Main {
	class LinkedListNode{
		String val;
		LinkedListNode next;
		LinkedListNode prev;
		LinkedListNode(String val,LinkedListNode next, LinkedListNode prev)
		{
			this.val = val;
			this.next = next;
			this.prev = prev;
		}
	}
    public static void main(String[] args) {
        Main mn = new Main();
        List<List<String>> airportTravelList = new ArrayList<List<String>>();
        List<String> airportTravel = new ArrayList<String>();
        airportTravel.add("ITO");
        airportTravel.add("KOA");
        airportTravelList.add(airportTravel);
        airportTravel = new ArrayList<String>();
        airportTravel.add("ANC");
        airportTravel.add("SEA");
        airportTravelList.add(airportTravel);
        airportTravel = new ArrayList<String>();
        airportTravel.add("LGA");
        airportTravel.add("CDG");
        airportTravelList.add(airportTravel);
        airportTravel = new ArrayList<String>();
        airportTravel.add("KOA");
        airportTravel.add("LGA");
        airportTravelList.add(airportTravel);
        airportTravel = new ArrayList<String>();
        airportTravel.add("PDX");
        airportTravel.add("ITO");
        airportTravelList.add(airportTravel);
        airportTravel = new ArrayList<String>();
        airportTravel.add("SEA");
        airportTravel.add("PDX");
        airportTravelList.add(airportTravel);
        List<List<String>> result = mn.orderAirports(airportTravelList);
        for(int i=0;i<result.size();i++)
        {
        	System.out.println("("+result.get(i).get(0)+"),("+result.get(i).get(1)+")");
        }
    }

    public List<List<String>> orderAirports(List<List<String>> airportTravelList)
    {
    	LinkedListNode head = null;
    	List<List<String>> result = new ArrayList<List<String>>();
    	HashMap<String,LinkedListNode> map = new HashMap<String,LinkedListNode>();
    	for(int i=0;i<airportTravelList.size();i++)
    	{
    		String airport1 = airportTravelList.get(i).get(0);
    		String airport2 = airportTravelList.get(i).get(1);

    		LinkedListNode node1 = null;
    		if(map.containsKey(airport1))
    		{
    			node1 = map.get(airport1);
    		}
    		else
    		{
				node1 = new LinkedListNode(airport1,null,null);
				map.put(airport1,node1);
    		}
    		LinkedListNode node2 = null;
    		if(map.containsKey(airport2))
    		{
    			node2 = map.get(airport2);
    		}
    		else
    		{
				node2 = new LinkedListNode(airport2,null,null);
				map.put(airport2,node2);
    		}
			
			node1.next = node2;
			node2.prev = node1;
			if(head==null)
			{
				head = node1;
			}
			else if(node2.val.equals(head.val))
			{
				while(node1.prev!=null)
				{
					node1= node1.prev;
				}
				head = node1;
			}
    	}
    	while(head.next!=null)
    	{
    		List<String> innerList = new ArrayList<String>();
    		innerList.add(head.val);
    		innerList.add(head.next.val);
    		result.add(innerList);
    		head = head.next;
    	}
    	return result;
    }
}