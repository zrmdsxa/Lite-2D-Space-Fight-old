using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		transform.Translate(0,0,10*Time.deltaTime);
	}
}
