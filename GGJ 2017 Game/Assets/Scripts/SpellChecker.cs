using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellChecker : MonoBehaviour {

	public GameObject FrontSpellChecker;
	public GameObject ProjectilePrefab;

	public GameObject forearmObj;

	public bool spellDone = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.Equals(FrontSpellChecker))
		{
			Instantiate(ProjectilePrefab, forearmObj.transform.position, forearmObj.transform.rotation);
		}
	}

	void OnTriggerExit()
	{
		spellDone = false;
	}
}
