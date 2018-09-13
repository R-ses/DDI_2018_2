using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Panel : MonoBehaviour {
    private bool paused;
    private GameObject pausepanel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ContinueGame()
    {

        Debug.Log("Continue");
        paused = false;
        pausepanel.SetActive(paused);

    }

    public void ResetGame()
    {

        Debug.Log("Reset");
        SceneManager.LoadScene(1);

    }
}
