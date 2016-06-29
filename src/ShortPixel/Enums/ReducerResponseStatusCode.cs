namespace ShortPixel.Enums
{
    public enum ReducerResponseStatusCode
    {
        /// <summary>
        /// No errors, image scheduled for processing.
        /// </summary>
        ScheduledForProcessing = 0,

        /// <summary>
        /// No errors, image processed, download URL available.
        /// </summary>
        Processed = 2,

        /// <summary>
        /// Invalid URL. Please make sure the URL is properly urlencoded and points to a valid image file.
        /// </summary>
        InvalidURL = -102,

        /// <summary>
        /// URL is missing for the call.
        /// </summary>
        URLIsMissing = -105,

        /// <summary>
        /// URL is inaccessible from our server(s) due to access restrictions.
        /// </summary>
        URLIsInaccessible = -106,

        /// <summary>
        /// Too many URLs in a POST, maximum allowed has been exceeded.
        /// </summary>
        TooManyURLs = -107,

        /// <summary>
        /// Invalid user used for optimizing images from a particular domain.
        /// </summary>
        InvalidUser = -108,

        /// <summary>
        /// Invalid image format.
        /// </summary>
        InvalidImageFormat = -201,

        /// <summary>
        /// Invalid image. The URL was valid but it did not point to an image.
        /// </summary>
        InvalidImage = -202,

        /// <summary>
        /// The file is larger than the remaining quota.
        /// </summary>
        FileIsTooBig = -301,

        /// <summary>
        /// The file is no longer available.
        /// </summary>
        FileIsNotAvailable = -302,

        /// <summary>
        /// Internal API error: the file was not written on disk.
        /// </summary>
        InternalAPIError = -303,

        /// <summary>
        /// Invalid API key. Please check that the API key is the one provided to you.
        /// </summary>
        InvalidAPIKey = -401,

        /// <summary>
        /// Quota exceeded. You need to subscribe to a larger plan or to buy an additional one time package to increase your quota.
        /// </summary>
        QuotaExceeded = -403
    }
}
