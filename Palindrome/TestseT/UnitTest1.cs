using System;
using Xunit;
using LibraryrarbiL;

namespace TestseT
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.True(test.IsPalendrome(""));
        }
        
        [Fact]
        public void Test2()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.True(test.IsPalendrome("jimij"));
        }
        
        [Fact]
        public void Test3()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.True(test.IsPalendrome("Racecar"));
        }
        
        [Fact]
        public void Test4()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.True(test.IsPalendrome("Ra cE Ca    r"));
        }
        
        [Fact]
        public void Test5()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.True(test.IsPalendrome("Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era."));
        }

        [Fact]
        public void TestF1()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.False(test.IsPalendrome("jimmy"));
        }


        [Fact]
        public void TestF2()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.False(test.IsPalendrome("racecarr"));
        }

        [Fact]
        public void TestF3()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.False(test.IsPalendrome("tostidos"));
        }

        [Fact]
        public void TestF4()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.False(test.IsPalendrome("WATabuRGER"));
        }

        [Fact]
        public void TestF5()
        {
            ICheckPalindrome test = new PalendromeCheker();
            Assert.False(test.IsPalendrome("234235u56222o00294"));
        }

    }
}
