class Solution {
    public int countPrimes(int n) {
        if(n<3)
        {
            return 0;
        }
        boolean[] primes = new boolean[n+1];
        Arrays.fill(primes,true);
        primes[1]=false;
        primes[2] = true;
        for(int i=2;i*i<n;i++)
        {
            if(primes[i])
            {
                int j = i*2;
                while(j<=n)
                {
                    primes[j] = false;
                    j = j+i;
                }
            }
        }
        int count = 0;
        for(int i=1;i<n;i++)
        {
            if(primes[i])
            {
                count++;
            }
        }
        return count;
    }
}