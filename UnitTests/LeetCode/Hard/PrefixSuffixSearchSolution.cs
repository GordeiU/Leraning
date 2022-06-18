using Learning.Shared.Classes.LeetCode.Hard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Hard {
    [TestClass]
    public class PrefixSuffixSearchSolutionTest {
        private PrefixSuffixSearchSolution TestingClass { get; set; } = default!;

        [TestMethod]
        public void CheckIfExists_OneWordExists() {
            string[] words = new string[] { "apple" };
            PrefixSuffixSearchSolution TestingClass = new PrefixSuffixSearchSolution(words);

            int actual = TestingClass.F("a", "e");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfExists_OneWordDoesntExist_SuffixLongerThanWord() {
            string[] words = new string[] { "apple" };
            PrefixSuffixSearchSolution TestingClass = new PrefixSuffixSearchSolution(words);

            int actual = TestingClass.F("a", "les");
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfExists_OneWordDoesntExist_PrefixPartlyExists() {
            string[] words = new string[] { "apple" };
            PrefixSuffixSearchSolution TestingClass = new PrefixSuffixSearchSolution(words);

            int actual = TestingClass.F("apd", "le");
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfExists_TwoWordExists_SecondWordLonger() {
            // Both match but as per task should return longer word i.e apples
            string[] words = new string[] { "apple", "apples" };
            PrefixSuffixSearchSolution TestingClass = new PrefixSuffixSearchSolution(words);

            int actual = TestingClass.F("ap", "le");
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfExists_MoreWordExists() {
            // Both match but as per task should return longer word i.e apples
            string[] words = new string[] {
                "Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing",
                "elit", "Aenean", "venenatis", "convallis", "porttitor", "Integer",
                "quam", "massa", "luctus", "sed", "pellentelesque", "et", "dictum",
                "pellentelasdfesque", "pellenasdftelesque", "pellenasdftelesque"
                };

            PrefixSuffixSearchSolution TestingClass = new PrefixSuffixSearchSolution(words);

            int actual = TestingClass.F("pel", "que");
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}