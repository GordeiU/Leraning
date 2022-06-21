using System.Collections.Generic;
using System.Linq;
using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class SearchSuggestionsSystemSolutionTest {
        private SearchSuggestionsSystemSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new SearchSuggestionsSystemSolution();
        }

        [TestMethod]
        public void SuggestedProducts_ShortOne() {
            string[] words = new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            bool isEqual = false;

            List<List<string>> actual = TestingClass.SuggestedProducts(words, "mouse");
            List<List<string>> expected = new List<List<string>>() {
                new List<string>() {"mobile", "moneypot", "monitor"},
                new List<string>() {"mobile", "moneypot", "monitor"},
                new List<string>() {"mouse", "mousepad"},
                new List<string>() {"mouse", "mousepad"},
                new List<string>() {"mouse", "mousepad"}
            };

            if (actual.Count != expected.Count) {
                isEqual = false;
            }

            for (int idx = 0; idx < expected.Count; idx++) {
                isEqual = isEqual && Enumerable.SequenceEqual(actual[idx], expected[idx]);
            }

            Assert.IsTrue(isEqual);
        }
    }
}