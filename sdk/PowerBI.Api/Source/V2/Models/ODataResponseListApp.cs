// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI installed App list
    /// </summary>
    public partial class ODataResponseListApp
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListApp class.
        /// </summary>
        public ODataResponseListApp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListApp class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The installed apps</param>
        public ODataResponseListApp(string odatacontext = default(string), IList<App> value = default(IList<App>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the installed apps
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<App> Value { get; set; }

    }
}