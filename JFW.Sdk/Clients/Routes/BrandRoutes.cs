/*
* Description: This class provides all routes related to the brand.
* Author: Steve Bang.
* History:
* - 2024-08-12: Created - Steve Bang.
*/


namespace JFW.Sdk.Clients.Routes
{
    /// <summary>
    /// This class provides all routes related to the brand.
    /// </summary>
    public class BrandRoutes
    {
        /// <summary>
        /// The base URL for the brand.
        /// </summary>
        public const string BaseUrl = "api/brands";

        /// <summary>
        /// This route gets brand by the given ID.
        /// </summary>
        public const string GetById = "{id}";

        /// <summary>
        /// This route gets all the brand links.
        /// </summary>
        public const string GetBrandLinks = "links";
    }
}
