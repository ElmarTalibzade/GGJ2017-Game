using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellChecker : MonoBehaviour {

	public GameObject FrontSpellChecker;

	public bool spellDone = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.Equals(FrontSpellChecker))
		{
			if (!spellDone)
			{
				Debug.Log("Touching the " + other.name);
				spellDone = true;
			}
		}
	}

	void OnTriggerExit()
	{
		spellDone = false;
	}
}
