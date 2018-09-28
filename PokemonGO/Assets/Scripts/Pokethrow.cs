using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokethrow : MonoBehaviour {

    public GameObject PokeballPrefab;
	public float throwSpeed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(Vector3.zero);
		GameObject pokeball =  Instantiate(PokeballPrefab, transform.position, transform.rotation );
		
		pokeball.GetComponent<Rigidbody>().AddForce(transform.forward * throwSpeed, ForceMode.Impulse);
		
	}
}
