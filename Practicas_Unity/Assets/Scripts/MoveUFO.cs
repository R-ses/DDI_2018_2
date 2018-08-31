using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUFO : MonoBehaviour {

    public GameObject UFO;
    public float M_SPD = 0.1f;
    public float RelLocationMinX = 0f;
    public float RelLocationMaxX = 20f;
    public bool Dir = true; //Dir (true = right <> false = left)
    public Vector3 Pos = new Vector3();
    int change_speed = 0;

	// Use this for initialization
	void Start () {

        Pos.x = UFO.transform.position.x;
        RelLocationMinX = UFO.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

        Movement();
         
    }


    public void Movement()
    {

        if(change_speed == 30)
        {
            if (Dir)
            {
                Pos.x = Pos.x + M_SPD;
                UFO.transform.Translate(Pos);

                if (UFO.transform.position.x > RelLocationMaxX)
                {
                    Dir = false;
                }


            }
            else
            {
                Pos.x = Pos.x - M_SPD;
                UFO.transform.Translate(Pos);

                if (UFO.transform.position.x < RelLocationMinX)
                {
                    Dir = false;
                }
                
            }

            change_speed = 0;

        }
        else
        {
            change_speed++;
        }
        
    }
}
