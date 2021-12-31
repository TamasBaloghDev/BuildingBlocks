using System;
using Aspose.ThreeD;
using Hypar.Functions;
using Elements;
using Elements.Geometry;




namespace Sandbox
{
    class Sandbox
    {
        static void Main()
        {
            // Create geometry and export GLTF file
            string str_PathToGLTF = GeometryCreator.CreateGeometry();
            
            // 
            Visualiser c_Visualiser = new Visualiser(str_PathToGLTF);
            c_Visualiser.ShowGeometry();
        }

    }
}
