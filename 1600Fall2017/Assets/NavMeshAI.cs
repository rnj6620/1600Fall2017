using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAI : CharacterControl {

	public Transform player;
	public NavMeshAgent agent; 
	public Vector3 moveCamera; 
	void Update () {
		agent.destination = player.position; // gets camera to follow player
		
	}
}
