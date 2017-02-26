using System;
using NUnit.Framework;
using UnitTestApp1.Model;
using HelloAndroid.ViewModel;

namespace UnitTestApp1
{
    [TestFixture]
    public class TestsSample
    {
        [Test]
        public void MainViewModel_TestRefresh_ShouldSucceed()
        {
            var service = new TestYoutubeService();
            var vm = new MainViewModel(service);

            vm.RefreshCommand.Execute(null);

            Assert.AreEqual(TestYoutubeService.ResultPassed, vm.Result);
        }
    }
}