using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class MonsterAI : MonoBehaviour {

	public bool isAlive = true;
	public Transform player;

	NavMeshAgent agent;
	Animator animator;

	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
	}
	
	void Update () 
	{
		if (isAlive)
		{
			agent.SetDestination(player.position);
			
			animator.SetFloat("speed", agent.velocity.magnitude);
		}
	}

	void OnTriggerEnter(Collider other)
	{

	}
}
