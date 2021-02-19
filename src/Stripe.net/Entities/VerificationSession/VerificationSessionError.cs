namespace Stripe
{
    using Newtonsoft.Json;

    public class VerificationSessionError : StripeEntity<VerificationSessionError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification or user-session failure.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable message giving the reason for the failure. These messages can be shown to your users.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
