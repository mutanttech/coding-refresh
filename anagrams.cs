using System;
using System.Collections;

public class GFG{
	static public void Main ()
	{
		Console.WriteLine($"Strings are anagrams? {AreAnagrams("geeks","sgeek")}");
	}

	public static bool AreAnagrams(string s1, string s2)
  {
	    // total number of characters should be same 
	    //characters should appear same number of time in the string
      if(s1.Length != s2.Length) return false;
	    int[] freq = new int[26];//considering 26 letters in english
       
        // Count frequency of each character in string s1
        foreach (char ch in s1)
        {
            freq[ch - 'a']++;
        }

        // Count frequency of each character in string s2
        foreach (char ch in s2)
        {
            freq[ch - 'a']--;
        }

        // Check if all frequencies are zero
        foreach (int count in freq) {
            if (count != 0)
                return false;
        }

        return true;
	}
}
