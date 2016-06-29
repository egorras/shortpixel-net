using System;

namespace ShortPixel.Client
{
    /// <summary>
    /// The API call returns a JSON encoded data structure that shows the outcome of the call.
    /// </summary>
    public class ReducerResponse
    {
        /// <summary>
        /// Contains the status message for the call.
        /// </summary>
        public ReducerResponseStatus Status { get; set; }

        /// <summary>
        /// This is the original URL provided in the API call.
        /// </summary>
        public string OriginalURL { get; set; }

        /// <summary>
        /// Download URL for the optimized image using lossless compression.
        /// </summary>
        public string LosslessURL { get; set; }

        /// <summary>
        /// Download URL for the optimized image using lossy compression.
        /// </summary>
        public string LossyURL { get; set; }

        /// <summary>
        /// Size of the original image.
        /// </summary>
        public int OriginalSize { get; set; }

        /// <summary>
        /// Size of the lossless compressed image.
        /// </summary>
        public int LoselessSize { get; set; }

        /// <summary>
        /// Size of the lossy compressed image.
        /// </summary>
        public int LossySize { get; set; }

        /// <summary>
        /// Timestamp of the file processing.
        /// </summary>
        public DateTime TimeStamp { get; set; }

        public double PercentImprovement { get; set; }
    }
}
