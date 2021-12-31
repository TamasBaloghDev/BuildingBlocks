﻿using Xunit;
using System.Linq;
using Newtonsoft.Json;
using Elements;
using Hypar.Functions.Execution.Local;
using Elements.Serialization.glTF;
using Elements.Serialization.JSON;
using System.Collections.Generic;
using Elements.Geometry;


namespace EnvelopeBySketch.Tests
{
    /// <summary>
    /// Writes all new Elements to JSON output.
    /// Writes all new Elements and any incoming contextual Elements to GLB output.
    /// </summary>
    public class EnvelopeBySketchTests
    {
        private const string OUTPUT = "../../../_output/";

        [Fact]
        public void EnvelopeBySketchTest()
        {
            var polygon =
                new Polygon
                (
                    new[]
                    {
                        new Vector3(6.0, 0.0),
                        new Vector3(9.0, 0.0),
                        new Vector3(9.0, 4.0),
                        new Vector3(13.0, 4.0),
                        new Vector3(13.0, 7.0),
                        new Vector3(9.0, 7.0),
                        new Vector3(9.0, 11.0),
                        new Vector3(6.0, 11.0),
                        new Vector3(6.0, 7.0),
                        new Vector3(2.0, 7.0),
                        new Vector3(2.0, 4.0),
                        new Vector3(6.0, 4.0)
                    });
            var inputs =
                new EnvelopeBySketchInputs(
                    perimeter: polygon,
                    setbackInterval: 50.0,
                    useSetbacks: true,
                    setbackDepth: 5.0,
                    minimumTierArea: 100.0,
                    buildingHeight: 50,
                    foundationDepth: 3.0,
                    bucketName: "", 
                    uploadsBucket: "", 
                    new Dictionary<string, string>(), "", "", "");
            var outputs =
                EnvelopeBySketch.Execute(new Dictionary<string, Model> { { "Envelope", new Model() } }, inputs);
            System.IO.File.WriteAllText(OUTPUT + "EnvelopeBySketch.json", outputs.Model.ToJson());
            outputs.Model.ToGlTF(OUTPUT + "EnvelopeBySketch.glb");
        }
    }
}
