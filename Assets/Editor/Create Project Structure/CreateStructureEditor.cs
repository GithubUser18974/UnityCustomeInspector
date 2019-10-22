using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace MyTools
{
    public class CreateStructureEditor : Editor
    {
        [MenuItem("MyTools/Projects/Project Setup Tool")]
        public static void InitProjectSetupTool()
        {
            CreateStructureWindow.InitWindow();
        }
    }
}
