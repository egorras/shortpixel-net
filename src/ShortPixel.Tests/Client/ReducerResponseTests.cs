using System;
using Newtonsoft.Json;
using ShortPixel.Client;
using ShortPixel.Enums;
using Xunit;

namespace ShortPixel.Tests.Client
{
    public class ReducerResponseTests
    {
        [Fact]
        internal static void Should_deserialize_from_json()
        {
            var json =
                @"{""Status"":{""Code"":2,""Message"":""message"",""QuotaExceededFlag"":true},""OriginalURL"":""original_url"",""LosslessURL"":""lossless_url"",""LossyURL"":""lossy_url"",""OriginalSize"":42,""LoselessSize"":41,""LossySize"":40,""TimeStamp"":""2016-06-29T00: 00:00"",""PercentImprovement"":2.0}";
            var response = JsonConvert.DeserializeObject<ReducerResponse>(json);
            Assert.Equal(ReducerResponseStatusCode.Processed, response.Status.Code);
            Assert.Equal("message", response.Status.Message);
            Assert.Equal(true, response.Status.QuotaExceededFlag);
            Assert.Equal("original_url", response.OriginalURL);
            Assert.Equal("lossless_url", response.LosslessURL);
            Assert.Equal("lossy_url", response.LossyURL);
            Assert.Equal(42, response.OriginalSize);
            Assert.Equal(41, response.LoselessSize);
            Assert.Equal(40, response.LossySize);
            Assert.Equal(new DateTime(2016, 6, 29), response.TimeStamp);
            Assert.Equal(2, response.PercentImprovement);
        }
    }
}
