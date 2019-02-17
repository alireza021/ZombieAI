using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxing : MonoBehaviour {

	private Animator animator;
	private HitEnemy enemyScript;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		enemyScript = GetComponentInChildren<HitEnemy>();
		if (enemyScript!=null){
			enemyScript.isBoxing = false;
		}

	}

	// Update is called once per frame
	void Update () {
		bool boxing = Input.GetMouseButton(0);
		animator.SetBool("isBoxing", boxing);
		if (enemyScript != null){
			enemyScript.isBoxing = boxing;
		}

	}
}