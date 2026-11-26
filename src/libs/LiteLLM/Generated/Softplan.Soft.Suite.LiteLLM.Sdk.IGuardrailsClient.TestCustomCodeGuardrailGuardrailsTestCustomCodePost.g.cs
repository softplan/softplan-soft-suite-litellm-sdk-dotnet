#nullable enable

namespace Softplan.Soft.Suite.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Test Custom Code Guardrail<br/>
        /// Test custom code guardrail logic without creating a guardrail.<br/>
        /// This endpoint allows admins to experiment with custom code guardrails by:<br/>
        /// 1. Compiling the provided code in a sandbox<br/>
        /// 2. Executing the apply_guardrail function with test input<br/>
        /// 3. Returning the result (allow/block/modify)<br/>
        /// 👉 [Custom Code Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/custom_code_guardrail)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails/test_custom_code" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "custom_code": "def apply_guardrail(inputs, request_data, input_type):\n    for text in inputs[\"texts\"]:\n        if regex_match(text, r\"\\d{3}-\\d{2}-\\d{4}\"):\n            return block(\"SSN detected\")\n    return allow()",<br/>
        ///         "test_input": {<br/>
        ///             "texts": ["My SSN is 123-45-6789"]<br/>
        ///         },<br/>
        ///         "input_type": "request"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Success Response (blocked):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "block",<br/>
        ///         "reason": "SSN detected"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (allowed):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "allow"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (modified):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "modify",<br/>
        ///         "texts": ["My SSN is [REDACTED]"]<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response (compilation error):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": false,<br/>
        ///     "result": null,<br/>
        ///     "error": "Syntax error in custom code: invalid syntax (&lt;guardrail&gt;, line 1)",<br/>
        ///     "error_type": "compilation"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TestCustomCodeGuardrailResponse> TestCustomCodeGuardrailGuardrailsTestCustomCodePostAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TestCustomCodeGuardrailRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Custom Code Guardrail<br/>
        /// Test custom code guardrail logic without creating a guardrail.<br/>
        /// This endpoint allows admins to experiment with custom code guardrails by:<br/>
        /// 1. Compiling the provided code in a sandbox<br/>
        /// 2. Executing the apply_guardrail function with test input<br/>
        /// 3. Returning the result (allow/block/modify)<br/>
        /// 👉 [Custom Code Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/custom_code_guardrail)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails/test_custom_code" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "custom_code": "def apply_guardrail(inputs, request_data, input_type):\n    for text in inputs[\"texts\"]:\n        if regex_match(text, r\"\\d{3}-\\d{2}-\\d{4}\"):\n            return block(\"SSN detected\")\n    return allow()",<br/>
        ///         "test_input": {<br/>
        ///             "texts": ["My SSN is 123-45-6789"]<br/>
        ///         },<br/>
        ///         "input_type": "request"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Success Response (blocked):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "block",<br/>
        ///         "reason": "SSN detected"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (allowed):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "allow"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (modified):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "modify",<br/>
        ///         "texts": ["My SSN is [REDACTED]"]<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response (compilation error):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": false,<br/>
        ///     "result": null,<br/>
        ///     "error": "Syntax error in custom code: invalid syntax (&lt;guardrail&gt;, line 1)",<br/>
        ///     "error_type": "compilation"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.LiteLLM.Sdk.TestCustomCodeGuardrailResponse>> TestCustomCodeGuardrailGuardrailsTestCustomCodePostAsResponseAsync(

            global::Softplan.Soft.Suite.LiteLLM.Sdk.TestCustomCodeGuardrailRequest request,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Custom Code Guardrail<br/>
        /// Test custom code guardrail logic without creating a guardrail.<br/>
        /// This endpoint allows admins to experiment with custom code guardrails by:<br/>
        /// 1. Compiling the provided code in a sandbox<br/>
        /// 2. Executing the apply_guardrail function with test input<br/>
        /// 3. Returning the result (allow/block/modify)<br/>
        /// 👉 [Custom Code Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/custom_code_guardrail)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails/test_custom_code" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "custom_code": "def apply_guardrail(inputs, request_data, input_type):\n    for text in inputs[\"texts\"]:\n        if regex_match(text, r\"\\d{3}-\\d{2}-\\d{4}\"):\n            return block(\"SSN detected\")\n    return allow()",<br/>
        ///         "test_input": {<br/>
        ///             "texts": ["My SSN is 123-45-6789"]<br/>
        ///         },<br/>
        ///         "input_type": "request"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Success Response (blocked):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "block",<br/>
        ///         "reason": "SSN detected"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (allowed):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "allow"<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response (modified):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": true,<br/>
        ///     "result": {<br/>
        ///         "action": "modify",<br/>
        ///         "texts": ["My SSN is [REDACTED]"]<br/>
        ///     },<br/>
        ///     "error": null,<br/>
        ///     "error_type": null<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response (compilation error):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "success": false,<br/>
        ///     "result": null,<br/>
        ///     "error": "Syntax error in custom code: invalid syntax (&lt;guardrail&gt;, line 1)",<br/>
        ///     "error_type": "compilation"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="customCode"></param>
        /// <param name="inputType">
        /// Default Value: request
        /// </param>
        /// <param name="requestData"></param>
        /// <param name="testInput"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.LiteLLM.Sdk.TestCustomCodeGuardrailResponse> TestCustomCodeGuardrailGuardrailsTestCustomCodePostAsync(
            string customCode,
            object testInput,
            string? inputType = default,
            object? requestData = default,
            global::Softplan.Soft.Suite.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}