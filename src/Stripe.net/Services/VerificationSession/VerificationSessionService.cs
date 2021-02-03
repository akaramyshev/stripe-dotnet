namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationSessionService : Service<VerificationSession>,
        ICreatable<VerificationSession, VerificationSessionCreateOptions>,
        IListable<VerificationSession, VerificationSessionListOptions>,
        IRetrievable<VerificationSession, VerificationSessionGetOptions>,
        IUpdatable<VerificationSession, VerificationSessionUpdateOptions>
    {
        public override string BasePath => "/v1/identity/verification_sessions";

        public virtual VerificationSession Cancel(string id, VerificationSessionCancelOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<VerificationSession> CancelAsync(string id, VerificationSessionCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public VerificationSession Create(VerificationSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.CreateEntity(options, requestOptions);
        }

        public Task<VerificationSession> CreateAsync(VerificationSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public VerificationSession Get(string id, VerificationSessionGetOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.GetEntity(id, options, requestOptions);
        }

        public Task<VerificationSession> GetAsync(string id, VerificationSessionGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public StripeList<VerificationSession> List(VerificationSessionListOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.ListEntities(options, requestOptions);
        }

        public Task<StripeList<VerificationSession>> ListAsync(VerificationSessionListOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public IEnumerable<VerificationSession> ListAutoPaging(VerificationSessionListOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public IAsyncEnumerable<VerificationSession> ListAutoPagingAsync(VerificationSessionListOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public VerificationSession Update(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating a Verification Session", "StripeVersion");
            }

            // Creating a Verification Session requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.UpdateEntity(id, options, requestOptions);
        }

        public Task<VerificationSession> UpdateAsync(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
