namespace Stripe
{
    using Newtonsoft.Json;

    public class VerificationSessionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// StripeVersion.
        /// </summary>
        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
