using Core;
using Xunit;

namespace Tests {
    public class UnitTest1 : SubStringFinder
    {
        public UnitTest1()
        {
        }

        [Fact]
        public void FailureShouldBeEmptyArray()
        {
            UnitTest1 finder = new UnitTest1();
            
            var subStringPositions = finder.Failure(null);

            Assert.Empty(subStringPositions); 
        }

        [Fact]
        public void FailureSimple()
        {
            UnitTest1 finder = new UnitTest1();
            
            var subStringPositions = finder.Failure("s");

            Assert.Equal(subStringPositions, new int[] { 0 }); 
        }

        [Fact]
        public void FailureSimple2()
        {
            UnitTest1 finder = new UnitTest1();
            
            var subStringPositions = finder.Failure("ss");

            Assert.Equal(subStringPositions, new int[] { 0, 1 }); 
        }

        [Fact]
        public void FailureSimple3()
        {
            UnitTest1 finder = new UnitTest1();
            
            var subStringPositions = finder.Failure("sass");

            Assert.Equal(subStringPositions, new int[] { 0, 0, 1, 1 }); 
        }

        [Fact]
        public void IndexesOfTest()
        {
            UnitTest1 finder = new UnitTest1();
            
            var indexes = finder.IndexesOf("abababa", "aba");

            Assert.Equal(indexes, new int[]{0, 2, 4}); 
        }

        [Fact]
        public void IndexesOfTest2()
        {
            UnitTest1 finder = new UnitTest1();
            
            var indexes = finder.IndexesOf("aabaab", "aa");

            Assert.Equal(indexes, new int[]{0, 3}); 
        }
    }
}