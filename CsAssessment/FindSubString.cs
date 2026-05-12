namespace CsAssessment
{
    /*
    Given a string s, find the length of the longest substring without duplicate characters.
 

    Example 1:
    Input: s = "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

    Example 2:
    Input: s = "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.

    Example 3:
    Input: s = "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.
    Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 
    Constraints:
    0 <= s.length <= 5 * 104
    s consists of English letters, digits, symbols and spaces.
    */
    public class FindSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            // Map to store the last seen index of each character
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                char currentChar = s[right];

                // If the character is already in the window, move the left pointer
                // to the right of the last seen position of that character
                if (lastSeen.ContainsKey(currentChar))
                {
                    left = Math.Max(lastSeen[currentChar] + 1, left);
                }

                // Update/Add the character's last seen index
                lastSeen[currentChar] = right;

                // Calculate the current window size and update maxLength
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}

