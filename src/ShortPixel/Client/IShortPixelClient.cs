using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShortPixel.Client
{
    /// <summary>
    /// ShortPixel API client.
    /// <see cref="https://shortpixel.com/api-docs"/>
    /// </summary>
    public interface IShortPixelClient
    {
        /// <summary>
        /// Shrink an image based on the URL of the image. The image has to be available online in order to be shrunk via this API.
        /// </summary>
        IList<ReducerResponse> Reducer(ReducerRequest reducerRequest);

        /// <summary>
        /// Shrink an image based on the URL of the image. The image has to be available online in order to be shrunk via this API.
        /// </summary>
        Task<IList<ReducerResponse>> ReducerAsync(ReducerRequest reducerRequest);
    }
}
