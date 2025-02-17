namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Represents server restart parameters.</summary>
    public partial class RestartParameter :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IRestartParameter,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IRestartParameterInternal
    {

        /// <summary>Backing field for <see cref="FailoverMode" /> property.</summary>
        private string _failoverMode;

        /// <summary>Failover mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string FailoverMode { get => this._failoverMode; set => this._failoverMode = value; }

        /// <summary>Backing field for <see cref="RestartWithFailover" /> property.</summary>
        private bool? _restartWithFailover;

        /// <summary>Indicates whether to restart the server with failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public bool? RestartWithFailover { get => this._restartWithFailover; set => this._restartWithFailover = value; }

        /// <summary>Creates an new <see cref="RestartParameter" /> instance.</summary>
        public RestartParameter()
        {

        }
    }
    /// Represents server restart parameters.
    public partial interface IRestartParameter :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>Failover mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Failover mode.",
        SerializedName = @"failoverMode",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverMode { get; set; }
        /// <summary>Indicates whether to restart the server with failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether to restart the server with failover.",
        SerializedName = @"restartWithFailover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RestartWithFailover { get; set; }

    }
    /// Represents server restart parameters.
    internal partial interface IRestartParameterInternal

    {
        /// <summary>Failover mode.</summary>
        string FailoverMode { get; set; }
        /// <summary>Indicates whether to restart the server with failover.</summary>
        bool? RestartWithFailover { get; set; }

    }
}