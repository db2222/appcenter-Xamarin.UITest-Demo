using NUnit.Framework;
using Xamarin.UITest;

namespace UITestDemo.UITest
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        [OneTimeSetUp]
        public void GlobalInit()
        {
            ConfigureApp
                .iOS
                .StartApp();
        }
    }
}