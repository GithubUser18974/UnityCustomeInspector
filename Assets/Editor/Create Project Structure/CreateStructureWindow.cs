using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace MyTools
{
    public class CreateStructureWindow : EditorWindow
    {
        static CreateStructureWindow mainWindow;



        public static void InitWindow()
        {
            mainWindow = EditorWindow.GetWindow<CreateStructureWindow>("Create Structure Window");
            mainWindow.Show();
        }
        private void OnGUI()
        {
            EditorGUILayout.LabelField("Create Structure Window");
        }
    }
}