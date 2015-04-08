using UnityEngine;
using System.Collections;

public class GBanana : MonoBehaviour {

	public AnimationClip clipRotate;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter (Collider other) {
		Debug.Log (other.name);
		if (other.gameObject.tag == "Player") {
			animation.Play(clipRotate.name);
		}
	}
}
