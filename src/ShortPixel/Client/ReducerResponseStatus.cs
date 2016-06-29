using ShortPixel.Enums;

namespace ShortPixel.Client
{
    /// <summary>
    /// Contains the status message for the call.
    /// </summary>
    public class ReducerResponseStatus
    {
        /// <summary>
        /// Outcome of the call.
        /// </summary>
        public ReducerResponseStatusCode Code { get; set; }

        /// <summary>
        /// A text message explaining what the code stands for.
        /// </summary>
        public string Message { get; set; }

        public bool QuotaExceededFlag { get; set; }
    }
}
