using Xunit;

namespace dnx.foo.tests.AddNumbersSpecs
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class AddSomeNumbersTests : GivenA<AddSomeNumbers, int>
    {
        protected override void When()
        {
            base.When();

            Result = Target.AddTwoNumbers(10, 10);
        }

        [Then]
        public void TheResultIs20()
        {
            Assert.Equal(Result, 20);
        }
    }
}