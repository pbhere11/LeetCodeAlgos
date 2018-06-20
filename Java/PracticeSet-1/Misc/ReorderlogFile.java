/*
Example: 
Input: 
logFileSize = 5 
logLines = 
[al 9 2 3 1] 
[g1 Act car] 
[zo4 4 7] 
[abl off KEY dog] 
[a8 act zoo] 

Output: 
[gl Act car] 
[a8 act zoo] 
[ab1 off KEY dog] 
[al 9 2 3 1] 
[zo4 4 7] 
*/
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        Main mn = new Main();
        mn.reOrderlogFile();
    }
    public void reOrderlogFile(int logFileSize, List<String> logLines)
    {
    	buildHeap(logLines);
    }
    private buildHeap(List<String> logLines)
    {
    	
    }
}