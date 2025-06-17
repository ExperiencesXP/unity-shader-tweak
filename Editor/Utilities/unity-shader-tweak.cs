using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class FlexibleShaderFixer : EditorWindow
{
    private static List<Material> targetMaterials = new List<Material>();
    private Shader selectedShader;
    private Vector2 scrollPos;
    private static bool fixOnlyBroken = true;

    [MenuItem("Assets/Repair Material Shader...", true)]
    private static bool ValidateFixShader()
    {
        foreach (Object obj in Selection.objects)
        {
            if (obj is Material)
                return true;
        }
        return false;
    }

    [MenuItem("Assets/Repair Material Shader...")]
    private static void OpenShaderFixerWindow()
    {
        targetMaterials.Clear();

        foreach (Object obj in Selection.objects)
        {
            if (obj is Material mat)
            {
                if (!fixOnlyBroken || mat.shader.name == "Hidden/InternalErrorShader")
                {
                    targetMaterials.Add(mat);
                }
            }
        }

        if (targetMaterials.Count == 0)
        {
            EditorUtility.DisplayDialog("No valid materials", "No applicable materials found in the selection.", "OK");
            return;
        }

        FlexibleShaderFixer window = GetWindow<FlexibleShaderFixer>(true, "Shader Fixer");
        window.minSize = new Vector2(400, 300);
        window.ShowUtility();
    }

    private void OnGUI()
    {
        GUILayout.Label("Select a Shader to Apply", EditorStyles.boldLabel);
        selectedShader = EditorGUILayout.ObjectField("Replacement Shader", selectedShader, typeof(Shader), false) as Shader;

        EditorGUILayout.Space();
        fixOnlyBroken = EditorGUILayout.ToggleLeft("Only apply to broken materials", fixOnlyBroken);

        EditorGUILayout.Space();
        GUILayout.Label("Materials to Fix:", EditorStyles.boldLabel);

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

            int fixedCount = 0;
            foreach (Material mat in targetMaterials)
            {
                if (!fixOnlyBroken || mat.shader.name == "Hidden/InternalErrorShader")
                {
                    mat.shader = selectedShader;
                    EditorUtility.SetDirty(mat);
                    fixedCount++;
                }
            }

            AssetDatabase.SaveAssets();
            Debug.Log($"Updated {fixedCount} material(s) to shader: {selectedShader.name}");
            Close();
        }
    }
}
