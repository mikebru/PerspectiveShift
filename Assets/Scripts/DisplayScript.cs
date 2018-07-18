using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//activate all connected displays 
		for (int i = 0; i < Display.displays.Length; i++) {
			Display.displays [i].Activate ();
		}
	}

}
