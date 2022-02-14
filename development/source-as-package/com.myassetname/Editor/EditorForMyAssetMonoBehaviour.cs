using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(MyAssetMonoBehaviour))]
public class EditorForMyAssetMonoBehaviour : Editor 
{
	public override VisualElement CreateInspectorGUI()
	{
		var root = new VisualElement();
		root.Add(new Label() {text = "MyAsset custom inspector", style = { backgroundColor = Color.blue, color = Color.white}});
		root.Add( new IMGUIContainer( () =>
		{
			base.OnInspectorGUI();
		}));
		return root;
	}
}