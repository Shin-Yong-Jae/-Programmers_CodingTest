using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string numbers)
    {
        int nAnswer = 0;
        int nResult = 0;
        int nMod = 0;
        int nMax = 0;
        List<int> lstNumber = new List<int>(numbers.Length);
        
        foreach (var vCh in numbers.ToCharArray())
        {
            lstNumber.Add(vCh - 0x30);
        }
        lstNumber.Sort();

        for (int i = lstNumber.Count - 1; i >= 0; --i)
        {
            nMax += (lstNumber[i] * (int)Math.Pow(10, i));
        }
        
        List<bool> lstPrimes = new List<bool>(GetPrimes(nMax));
        List<int> lstPrimeDigit = new List<int>();

        for (int k = 2; k < lstPrimes.Count; ++k)
        {
            if (lstPrimes[k] == false)
                continue;

            bool bIncludeNumber = true;
            bool bIncludeDigit = false;
            nResult = k;

            lstPrimeDigit.Clear();
            do
            {
                nMod = nResult % 10;
                nResult /= 10;

                lstPrimeDigit.Add(nMod);
            } 
            while (nResult > 0);
            
            List<int> lstNumberTempo = new List<int>(lstNumber);

            for (int i = 0; i < lstPrimeDigit.Count; ++i)
            {
                bIncludeDigit = false;
                
                for (int j = 0; j < lstNumberTempo.Count; ++j)
                {
                    if (lstPrimeDigit[i] == lstNumberTempo[j])
                    {
                        bIncludeDigit = true;
                        lstNumberTempo[j] = -1;
                        break;
                    }
                }

                bIncludeNumber &= bIncludeDigit;
                if (!bIncludeNumber)
                {
                    break;
                }
            }

            if (bIncludeNumber)
                ++nAnswer;
        }

        return nAnswer;
    }

    bool[] GetPrimes(int nMax)
    {
        List<bool> lstPrimes = new List<bool>(nMax);

        for (int i = 0; i <= nMax; ++i)
            lstPrimes.Add(true);

        for (int i = 2; i <= nMax; ++i)
        {
            for (int j = i * 2; j <= nMax; j += i)
                lstPrimes[j] = false;
        }

        return lstPrimes.ToArray();
    }
}