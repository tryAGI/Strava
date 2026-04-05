
#nullable enable

namespace Strava
{
    /// <summary>
    /// Encapsulates the errors that may be returned from the API.
    /// </summary>
    public sealed partial class Fault
    {
        /// <summary>
        /// The set of specific errors associated with this fault, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Strava.Error>? Errors { get; set; }

        /// <summary>
        /// The message of the fault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Fault" /> class.
        /// </summary>
        /// <param name="errors">
        /// The set of specific errors associated with this fault, if any.
        /// </param>
        /// <param name="message">
        /// The message of the fault.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Fault(
            global::System.Collections.Generic.IList<global::Strava.Error>? errors,
            string? message)
        {
            this.Errors = errors;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fault" /> class.
        /// </summary>
        public Fault()
        {
        }
    }
}