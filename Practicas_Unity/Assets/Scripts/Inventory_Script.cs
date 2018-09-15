using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Script : MonoBehaviour {

	public GameObject InventoryPanel;
	public GameObject GamePanel;
	private bool on;
	public Sprite Sword_item_Sprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
	
	public void AddNewItem()
	{
		GameObject item = new GameObject();
		item.transform.SetParent(InventoryPanel.transform);
		Image imagen = item.AddComponent<Image>();
		imagen.sprite = Sword_item_Sprite;
		
	}
	
	private void Update()
	{
		if(Input.GetKeyUp(KeyCode.B))
		{
			InventoryPanel.SetActive(on);
            on = !on;
			GamePanel.SetActive(on);			
			
        }
		
		
		
		
	}
	
}
