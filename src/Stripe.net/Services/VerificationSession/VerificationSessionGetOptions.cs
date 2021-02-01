namespace Stripe
{
    using Newtonsoft.Json;

    public class VerificationSessionGetOptions : BaseOptions
    {
        /// <summary>
        /// StripeVersion.
        /// </summary>
        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
