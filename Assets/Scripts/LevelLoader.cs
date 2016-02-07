using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel (string name) {
		Debug.Log ("Load level requested for:"+name);
		Application.LoadLevel(name);
        print("Loaded level:" + Application.loadedLevelName);
	}
	public void QuitRequest(){
		Debug.Log ("Quit Requested");
		Application.Quit();
	}
}
