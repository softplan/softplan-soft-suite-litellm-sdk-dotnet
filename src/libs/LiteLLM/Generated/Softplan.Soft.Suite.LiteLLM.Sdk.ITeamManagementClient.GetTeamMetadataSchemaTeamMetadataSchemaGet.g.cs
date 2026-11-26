#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Get Team Metadata Schema<br/>
        /// Get the team metadata fields declared in ``general_settings.team_metadata_schema``.<br/>
        /// The UI uses this to prepopulate the team metadata form with the declared<br/>
        /// keys. Returns an empty ``fields`` list when no schema is configured. This<br/>
        /// schema is advisory; server-side enforcement stays with<br/>
        /// ``custom_team_metadata_validate``.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMetadataSchemaResponse> GetTeamMetadataSchemaTeamMetadataSchemaGetAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Metadata Schema<br/>
        /// Get the team metadata fields declared in ``general_settings.team_metadata_schema``.<br/>
        /// The UI uses this to prepopulate the team metadata form with the declared<br/>
        /// keys. Returns an empty ``fields`` list when no schema is configured. This<br/>
        /// schema is advisory; server-side enforcement stays with<br/>
        /// ``custom_team_metadata_validate``.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.TeamMetadataSchemaResponse>> GetTeamMetadataSchemaTeamMetadataSchemaGetAsResponseAsync(
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}