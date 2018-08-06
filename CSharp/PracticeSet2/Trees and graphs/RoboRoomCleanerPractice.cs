/**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 Input:
room = [
  [1,1,1,1,1,0,1,1],
  [1,1,1,1,1,0,1,1],
  [1,0,1,1,1,1,1,1],
  [0,0,0,1,0,0,0,0],
  [1,1,1,1,1,1,1,1]
],
row = 1,
col = 3
 */
class Solution {
    public void CleanRoom(Robot robot) {
    	HashSet<string> visited = new HashSet<string>();
        DFS(robot,0,0,visited,0);
    }
    private void DFS(Robot robot, int i, int j, HashSet<string> visited, int dir)
    {
    	string key = i+","+j;
    	if(!visited.Contains(key))
    	{
    		robot.Clean();
    		visited.Add(key);
    		for(int k=0;k<4;k++)
    		{
    			int x = i;
    			int y = j;
    			if(robot.Move())
    			{
    				//check the direction for next key
    				if(dir==0)
    				{
    					x--;
    				}
    				else if(dir ==90)
    				{
    					y++;
    				}
    				else if(dir==180)
    				{
    					x++;
    				}
    				else if(dir==270)
    				{
    					y--;
    				}
    				DFS(robot,x,y,visited,dir);
    				robot.TurnLeft();
    				robot.TurnLeft();
    				robot.Move();
    				robot.TurnRight();
    				robot.TurnRight();
    			}
    			robot.TurnRight();
    			dir+=90;
    			dir%=360;
    		}
    	}
    }
}