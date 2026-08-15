using Xunit;
using SampleApp;

namespace SampleApp.Tests {
    public class ProgramTests {
        [Fact]
        public void TestAdd() {
            Assert.Equal(5, Program.Add(2, 3));
        }
    }
}
