using System;
using System.Collections.Generic;
using System.Text;

using Aspose.ThreeD;
using Hypar.Functions;
using Elements;
using Elements.Geometry;

namespace Sandbox
{
    public class Visualiser
    {
        private string m_PathToGLTF;

        private Aspose.ThreeD.Formats.Html5SaveOptions m_SaveOptions;
        private string m_OutputHTML;
        private Aspose.ThreeD.Scene m_Scene;
        public Visualiser(string str_PathToGLTF)
        {
            m_PathToGLTF = str_PathToGLTF;
            SetupVisualiser();
        }

        public void ShowGeometry()
        {
            // load resultant HTML in default browser
            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/Chrome.exe",m_OutputHTML);
        }

        private void SetupVisualiser()
        {
            m_OutputHTML = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".html";

            // load GLTF scene via an instance of Scene
            m_Scene = new Aspose.ThreeD.Scene(m_PathToGLTF);
            // create an object of Html5SaveOptions and set properties for formatting
            m_SaveOptions = new Aspose.ThreeD.Formats.Html5SaveOptions()
            {
                // turn off the grid
                ShowGrid = true,
                // turn off the user interface
                ShowUI = true
            };

            // save 3D scene as HTML5
            m_Scene.Save(m_OutputHTML, m_SaveOptions);
        }

    }
}
