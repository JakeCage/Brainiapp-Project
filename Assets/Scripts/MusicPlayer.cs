using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

	public void Start () {
		if(instance != null){
			DestroyObject(gameObject);
			print ("Music Player Destroyed.");
		}
		else{
			instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}