#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Agent Skills Archive<br/>
        /// Stored skill upload, repacked so SKILL.md sits at the archive root.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AgentSkillsArchiveV1SkillsSkillIdArchiveGetAsync(
            string skillId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Skills Archive<br/>
        /// Stored skill upload, repacked so SKILL.md sits at the archive root.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> AgentSkillsArchiveV1SkillsSkillIdArchiveGetAsStreamAsync(
            string skillId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Skills Archive<br/>
        /// Stored skill upload, repacked so SKILL.md sits at the archive root.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<byte[]>> AgentSkillsArchiveV1SkillsSkillIdArchiveGetAsResponseAsync(
            string skillId,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}