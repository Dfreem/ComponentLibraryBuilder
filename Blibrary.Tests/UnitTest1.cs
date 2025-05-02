using Blibrary.Shared.Models;

using Microsoft.JSInterop;

namespace Blibrary.Tests
{
    public class BrowserStorageTests
    {
        public List<ScssVariable> TestColorSection { get; set; } = [];
        private IJSRuntime _jS;

        public BrowserStorageTests(IJSRuntime js)
        {
            _jS = js;
        }

        [SetUp]
        public void SetUp()
        {
            TestColorSection = [
                new(){ Key = "TestBlue", Value = "#0000ff" }
            ];
        }

        [Test]
        public void TestBrowserStorage_SaveToSession()
        {
            Assert.That(Js, Is.Not.Null);
        }
    }
}
