using System;
using Newtonsoft.Json;
using ShortPixel.Converters;

namespace ShortPixel.Client
{
    /// <summary>
    /// Container for data used to make API request.
    /// </summary>
    public class ReducerRequest
    {
        private const int WaitMinValue = 0;
        private const int WaitMaxValue = 30;

        private int wait;

        /// <summary>
        /// API key, as provided in your control panel and signup confirmation email.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Controls whether the image compression will use a lossy or lossless algorithm.
        /// <para>
        ///     True - Lossy compression. Lossy has a better compression rate than lossless compression.
        ///     The resulting image is not 100% identical with the original. Works well for photos taken with your camera.
        /// </para>
        /// <para>
        ///     False - Lossless compression.The shrunk image will be identical with the original and smaller in size.
        ///     Use this when you do not want to loose any of the original image's details. Works best for technical drawings, clip art and comics.
        /// </para>
        /// </summary>
        [JsonProperty("lossy")]
        [JsonConverter(typeof(BoolAsIntConverter))]
        public bool Lossy { get; set; }

        /// <summary>
        /// Set it between 1 and 30 to wait for that number of seconds for the conversion to be done before the API returns, 0 to return immediately.
        /// <para>
        ///     If the optimization is not done in the given amount of wait time,
        ///     Code 1 is returned and you can just redo the same post later to find out if the image is ready.
        /// </para>
        /// </summary>
        [JsonProperty("wait")]
        public int Wait
        {
            get { return wait; }
            set
            {
                if (value >= WaitMinValue && value <= WaitMaxValue)
                {
                    wait = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Value must be between {WaitMinValue} and {WaitMaxValue}.");
                }
            }
        }

        /// <summary>
        /// The list of URLs where the original image is located. They need to be valid URLs and urlencoded.
        /// </summary>
        [JsonProperty("urllist")]
        public string[] UrlList { get; set; }
    }
}
