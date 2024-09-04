/*
* Description: This class provides the credential information for the API.
* Author: Steve Bang.
* History:
* - 2024-08-12: Created - Steve Bang.
*/

namespace JFW.Sdk.Models.Requests
{
    /// <summary>
    /// This class represents the body of the authentication request.
    /// </summary>
    public class AuthenticationRequest
    {
        /// <summary>
        /// The authentication key for the API.
        /// </summary>
        public string AuthKey { get; set; }

        /// <summary>
        /// The brand URL for the API.
        /// </summary>
        public string BrandUrl { get; set; }

        /// <summary>
        /// The public key of the brand.
        /// </summary>
        public string PublicKey { get; set; }
    }
}
