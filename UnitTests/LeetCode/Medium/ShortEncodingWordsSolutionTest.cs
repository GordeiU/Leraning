using Learning.Shared.Classes.LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.UnitTests.LeetCode.Medium {
    [TestClass]
    public class ShortEncodingWordsSolutionTest {
        private ShortEncodingWordsSolution TestingClass { get; set; } = default!;

        [TestInitialize]
        public void TestInitialize() {
            TestingClass = new ShortEncodingWordsSolution();
        }

        [TestMethod]
        public void MinDistance_ShortOne() {
            string[] words = new string[] {"time", "me", "bell" };

            int actual = TestingClass.MinimumLengthEncoding(words);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinDistance_ShortTwo() {
            string[] words = new string[] { "time", "me", "bell", "test", "less", "mess", "grass" };

            int actual = TestingClass.MinimumLengthEncoding(words);
            int expected = 31;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinDistance_ShortThree() {
            string[] words = new string[] { "aab", "bab", "abb" };

            int actual = TestingClass.MinimumLengthEncoding(words);
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }
    }
}