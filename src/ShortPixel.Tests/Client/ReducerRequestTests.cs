using System;
using Newtonsoft.Json;
using ShortPixel.Client;
using Xunit;

namespace ShortPixel.Tests.Client
{
    public class ReducerRequestTests
    {
        [Fact]
        internal static void Should_serialize_to_json()
        {
            var request = new ReducerRequest
            {
                Key = "1",
                Lossy = true,
                UrlList = new[] {"url1", "url2"},
                Wait = 25
            };
            var json = JsonConvert.SerializeObject(request);
            Assert.Equal(@"{""key"":""1"",""lossy"":1,""wait"":25,""urllist"":[""url1"",""url2""]}", json);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(31)]
        internal static void Should_throw_exception_on_bad_wait_value(int wait)
        {
            var request = new ReducerRequest();
            var exception = Record.Exception(() => request.Wait = wait);
            Assert.NotNull(exception);
            Assert.IsType<ArgumentOutOfRangeException>(exception);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        internal static void Should_not_throw_exception_on_good_wait_value(int wait)
        {
            var request = new ReducerRequest();
            var exception = Record.Exception(() => request.Wait = wait);
            Assert.Null(exception);
        }
    }
}
