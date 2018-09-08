using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Pauser : MonoBehaviour {
	private bool paused = false;
    public GameObject pausepanel;
    public AudioSource musicmanager;
    private bool muted = false;

	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{

			paused = !paused;
            pausepanel.SetActive(paused);
            
        }

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
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

    public void Mute()
    {
        Debug.Log("Mute");
<<<<<<< HEAD

        musicmanager.mute = !musicmanager.mute;
=======
        musicmanager.SetActive(false);
        
>>>>>>> master
            
    }


}
