﻿using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public GameObject _checkpointZone;

	void OnTriggerEnter(Collider c){
		if(c.gameObject.CompareTag("Player")){
			_checkpointZone.GetComponent<Checkpoint>().Rollback();
		}
	}

}
