namespace Stripe
{
    using Newtonsoft.Json;

    public class VerificationSessionCancelOptions : BaseOptions
    {
        /// <summary>
        /// StripeVersion.
        /// </summary>
        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
