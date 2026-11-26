
#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}