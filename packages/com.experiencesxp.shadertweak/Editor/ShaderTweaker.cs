using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class ShaderTweaker : EditorWindow
{
    private static List<Material> targetMaterials = new List<Material>();
    private Shader selectedShader;
    private Vector2 scrollPos;

    [MenuItem("Assets/Tweak Shader on Materials...", true)]
    private static bool ValidateTweakShader()
    {
        foreach (Object obj in Selection.objects)
        {
            if (obj is Material)
                return true;
        }
        return false;
    }

    [MenuItem("Assets/Tweak Shader on Materials...")]
    private static void OpenShaderTweakerWindow()
    {
        targetMaterials.Clear();

        foreach (Object obj in Selection.objects)
        {
            if (obj is Material mat)
            {
                targetMaterials.Add(mat);
            }
        }

        if (targetMaterials.Count == 0)
        {
            EditorUtility.DisplayDialog("No materials found", "Please select one or more materials.", "OK");
            return;
        }

        ShaderTweaker window = GetWindow<ShaderTweaker>(true, "Shader Tweaker");
        window.minSize = new Vector2(400, 300);
        window.ShowUtility();
    }

    private void OnGUI()
    {
        GUILayout.Label("Select a Shader to Apply", EditorStyles.boldLabel);
        selectedShader = EditorGUILayout.ObjectField("Replacement Shader", selectedShader, typeof(Shader), false) as Shader;

        EditorGUILayout.Space();
        GUILayout.Label("Materials to Update:", EditorStyles.boldLabel);

        scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Height(150));
        foreach (Material mat in targetMaterials)
        {
            EditorGUILayout.ObjectField(mat, typeof(Material), false);
        }
        EditorGUILayout.EndScrollView();

        EditorGUILayout.Space();
        if (GUILayout.Button("Apply Shader"))
        {
            if (selectedShader == null)
            {
                EditorUtility.DisplayDialog("No Shader Selected", "Please choose a shader.", "OK");
                return;
            }

            int updatedCount = 0;
            foreach (Material mat in targetMaterials)
            {
                mat.shader = selectedShader;
                EditorUtility.SetDirty(mat);
                updatedCount++;
            }

            AssetDatabase.SaveAssets();
            Debug.Log($"Updated {updatedCount} material(s) to shader: {selectedShader.name}");
            Close();
        }
    }
}