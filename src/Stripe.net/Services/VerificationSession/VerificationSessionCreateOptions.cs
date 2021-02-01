namespace Stripe
{
    using Newtonsoft.Json;

    public class VerificationSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// RefreshUrl.
        /// </summary>
        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// ReturnUrl.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// StripeVersion.
        /// </summary>
        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}