using UnityEngine;
using System.Collections;

public class SimpleCharacterController : MonoBehaviour {

	Animator animator;
	void Start () {
		animator = GetComponent<Animator> ();//asign animator
	
	}
	
	// Update is called once per frame
	void Update () {
		if (animator) {
			float v = Input.GetAxis("Vertical");
			animator.SetFloat("Input V", v);
			print (v);
		}
	
	}
}
