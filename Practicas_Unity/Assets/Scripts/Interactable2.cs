﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable2 : MonoBehaviour
{
    public Color color;
    public GameObject infoPanel;
    private bool isPlayerInside = false;
    public float rotationSpeed = 3f;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        if (Input.GetKeyDown(KeyCode.I) && isPlayerInside)
        {
            gameObject.GetComponent<Renderer>().material.color = color;
        }
		if (Input.GetKeyDown(KeyCode.E) && isPlayerInside)
		{
				FindObjectOfType<Inventory_Script>().AddNewItem();
				Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
            isPlayerInside = true;
			
	
		
		
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
            isPlayerInside = false;
        }
    }
}
