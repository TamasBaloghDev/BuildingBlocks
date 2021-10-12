//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Represents a preset view attached to an element.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ViewScope : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public ViewScope(BBox3 @boundingBox, Camera @camera, bool @inclusive, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.BoundingBox = @boundingBox;
            this.Camera = @camera;
            this.Inclusive = @inclusive;
            }
    
        /// <summary>The "focus" extent for this view.</summary>
        [Newtonsoft.Json.JsonProperty("Bounding Box", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BBox3 BoundingBox { get; set; }
    
        /// <summary>The camera to use for this view.</summary>
        [Newtonsoft.Json.JsonProperty("Camera", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Camera Camera { get; set; }
    
        /// <summary>Should the bounding box be treated as Inclusive?</summary>
        [Newtonsoft.Json.JsonProperty("Inclusive", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Inclusive { get; set; }
    
    
    }
}