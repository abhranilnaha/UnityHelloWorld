using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello, World!");
	}

	void OnGUI() {
		GUILayout.Label ("Hello World from Unity!");
	}
}