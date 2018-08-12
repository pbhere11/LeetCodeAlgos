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
 Example:

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

1,1,1

Explanation:
All grids in the room are marked by either 0 or 1.
0 means the cell is blocked, while 1 means the cell is accessible.
The robot initially starts at the position of row=1, col=3.
From the top left corner, its position is one row below and three columns right.
 */
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
 */
class Solution {
    public void CleanRoom(Robot robot) {
        HashSet<string> visited = new HashSet<string>();
        DFS(robot,0,0,visited, 0);
    }
    private void DFS(Robot robot,int i, int j, HashSet<string> visited, int dir)
    {
    	/*
		1,1
    	*/
    	string key = i+","+j;
    	if(!visited.Contains(key))
    	{
    		robot.Clean();
    		visited.Add(key);
    		for(int k=0;k<4;k++)
    		{
    			if(robot.Move())
    			{
    				int x = i;
    				int y = j;
    				if(dir==0)
    				{
    					y++;
    				}
    				else if(dir == 90)
    				{
    					x++;
    				}
    				else if(dir == 180)
    				{
    					y--;
    				}
    				else if(dir == 270)
    				{
    					x--;
    				}
    				DFS(robot,x,y,visited,dir);
    				//move back
    				robot.TurnLeft();
    				robot.TurnLeft();
    				robot.Move();
    				//set direction back to original
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