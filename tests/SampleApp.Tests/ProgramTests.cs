using Xunit;
using SampleApp;

namespace SampleApp.Tests {
    public class ProgramTests {
        [Fact]
        public void TestAdd() {
            Assert.Equal(5, Program.Add(2, 3));
        }

        [Fact]
        public void TestSubtract() {
            Assert.Equal(1, Program.Subtract(3, 2));
        }
    }
}
