using UnityEngine;
using System.Collections;

public class MoveLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x + 5,248);
	}
}
