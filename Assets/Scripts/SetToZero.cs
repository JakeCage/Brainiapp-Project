using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetToZero : MonoBehaviour {
    public Text text;

	// Update is called once per frame
	public void DatFunction () {
        text.text = "0";
	}
}
