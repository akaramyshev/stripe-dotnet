namespace Stripe
{
    using Newtonsoft.Json;

    public class VerifiedOutputs : StripeEntity<VerifiedOutputs>
    {
        /// <summary>
        /// The person's address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public Dob Dob { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// This field is not included by default. To include it in the response, expand the id_number field.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// Country / type of verified national id number.
        /// </summary>
        [JsonProperty("id_number_type")]
        public string IdNumberType { get; set; }
    }
}
