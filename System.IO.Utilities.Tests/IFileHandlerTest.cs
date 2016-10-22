namespace System.IO.Utilities.Tests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class IFileHandlerTest
    {
        [Test]
        public void UsageExample()
        {
            var fileName = "somefile.txt";
            var someText = "some_text";
            var fileHandlerMockery = new Mock<IFileHandler>();
            fileHandlerMockery.Setup(x => x.ReadAllText(fileName)).Returns(someText);
            var someComponent = new SomeComponent();

            someComponent.FileHandler = fileHandlerMockery.Object;

            Assert.AreEqual(someText.ToUpperInvariant(), someComponent.GetContentInUppercase(fileName));
        }
    }

    public class SomeComponent
    {
        public IFileHandler FileHandler { get; set; }

        public string GetContentInUppercase(string fileName)
        {
            return this.FileHandler.ReadAllText(fileName).ToUpperInvariant();
        }
    }
}
