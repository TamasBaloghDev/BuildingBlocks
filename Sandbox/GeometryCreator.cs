using System;
using System.Collections.Generic;
using System.Text;
using Hypar.Functions;
using Elements;
using Hypar.Functions.Execution.Local;
using Elements.Serialization.glTF;
using Elements.Serialization.JSON;
using Elements.Geometry;
using EnvelopeBySketch;

namespace Sandbox
{
    class GeometryCreator
    {

        private const string OUTPUT = "_output/";
        public static string CreateGeometry()
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
                    }
                );

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

            System.IO.Directory.CreateDirectory(OUTPUT);

            var outputs =
                EnvelopeBySketch.EnvelopeBySketch.Execute(new Dictionary<string, Model> { { "Envelope", new Model() } }, inputs);
            System.IO.File.WriteAllText(OUTPUT + "Sandbox_EnvelopeBySketch.json", outputs.Model.ToJson());

            string output_path = OUTPUT + "Sandbox.glb";
            outputs.Model.ToGlTF(output_path);

            return output_path;

        }

    }
}
