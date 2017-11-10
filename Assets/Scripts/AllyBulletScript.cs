using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBulletScript : MonoBehaviour {

	Rigidbody m_rb;
	public float lifeTime = 2.0f;
	float time = 0.0f;

	// Use this for initialization
	void Awake () {
		m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= lifeTime){
			Destroy(gameObject);
		}
	}

	public void setVelocity(Vector3 vel){
		m_rb.velocity = vel;
		Debug.Log(m_rb.velocity);
	}
}
