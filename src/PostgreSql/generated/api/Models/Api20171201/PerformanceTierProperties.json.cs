namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Performance tier properties</summary>
    public partial class PerformanceTierProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json ? new PerformanceTierProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject into a new instance of <see cref="PerformanceTierProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PerformanceTierProperties(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_maxBackupRetentionDay = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("maxBackupRetentionDays"), out var __jsonMaxBackupRetentionDays) ? (int?)__jsonMaxBackupRetentionDays : MaxBackupRetentionDay;}
            {_minBackupRetentionDay = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("minBackupRetentionDays"), out var __jsonMinBackupRetentionDays) ? (int?)__jsonMinBackupRetentionDays : MinBackupRetentionDay;}
            {_maxStorageMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("maxStorageMB"), out var __jsonMaxStorageMb) ? (int?)__jsonMaxStorageMb : MaxStorageMb;}
            {_minLargeStorageMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("minLargeStorageMB"), out var __jsonMinLargeStorageMb) ? (int?)__jsonMinLargeStorageMb : MinLargeStorageMb;}
            {_maxLargeStorageMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("maxLargeStorageMB"), out var __jsonMaxLargeStorageMb) ? (int?)__jsonMaxLargeStorageMb : MaxLargeStorageMb;}
            {_minStorageMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber>("minStorageMB"), out var __jsonMinStorageMb) ? (int?)__jsonMinStorageMb : MinStorageMb;}
            {_serviceLevelObjective = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonArray>("serviceLevelObjectives"), out var __jsonServiceLevelObjectives) ? If( __jsonServiceLevelObjectives as Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives) (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.PerformanceTierServiceLevelObjectives.FromJson(__u) )) ))() : null : ServiceLevelObjective;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PerformanceTierProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PerformanceTierProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != this._maxBackupRetentionDay ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._maxBackupRetentionDay) : null, "maxBackupRetentionDays" ,container.Add );
            AddIf( null != this._minBackupRetentionDay ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._minBackupRetentionDay) : null, "minBackupRetentionDays" ,container.Add );
            AddIf( null != this._maxStorageMb ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._maxStorageMb) : null, "maxStorageMB" ,container.Add );
            AddIf( null != this._minLargeStorageMb ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._minLargeStorageMb) : null, "minLargeStorageMB" ,container.Add );
            AddIf( null != this._maxLargeStorageMb ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._maxLargeStorageMb) : null, "maxLargeStorageMB" ,container.Add );
            AddIf( null != this._minStorageMb ? (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNumber((int)this._minStorageMb) : null, "minStorageMB" ,container.Add );
            if (null != this._serviceLevelObjective)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.XNodeArray();
                foreach( var __x in this._serviceLevelObjective )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("serviceLevelObjectives",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}