using CsAssessment;

namespace CsAssessmentTest
{
    [TestClass]
    public sealed class FindSubstringTest
    {
        FindSubString _findSubstring = new FindSubString();

        [TestMethod]
        public void TestCase1()
        {
            string testInput = "abcabcbb";
            int result = _findSubstring.LengthOfLongestSubstring(testInput);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestCase2()
        {
            string testInput = "pwwkew";
            int result = _findSubstring.LengthOfLongestSubstring(testInput);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestCase3()
        {
            string testInput = "bbbbbb";
            int result = _findSubstring.LengthOfLongestSubstring(testInput);
            Assert.AreEqual(result, 1);
        }
    }
}
