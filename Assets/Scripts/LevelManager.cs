using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("new scene load " + name);
		Application.LoadLevel (name);
	}
}
