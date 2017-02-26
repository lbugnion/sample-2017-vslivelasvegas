using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Data;

namespace UnitTestApp1.Model
{
    public class TestYoutubeService : IYoutubeService
    {
        public const string ResultPassed = "Result passed";
        public const string ExceptionMessage = "There was an error";
        private bool _forceError;

        public Task<string> Refresh()
        {
            var tcs = new TaskCompletionSource<string>();

            if (_forceError)
            {
                tcs.SetException(new Exception(ExceptionMessage));
            }
            else
            {
                tcs.SetResult(ResultPassed);
            }

            return tcs.Task;
        }

        public TestYoutubeService(bool forceError = false)
        {
            _forceError = forceError;
        }
    }
}