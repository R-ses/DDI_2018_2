using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Canvas_Behav_Panels : MonoBehaviour
{
    private bool paused = false;
    private bool inv = false;
    

    public GameObject pausepanel;
    public GameObject invpanel;
    public GameObject Gamepanel;
    public AudioSource musicmanager;
    private bool muted = false;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            inv = false;
            invpanel.SetActive(inv);
            paused = !paused;
            pausepanel.SetActive(paused);
            
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            paused = false;
            pausepanel.SetActive(paused);
            inv = !inv;
            invpanel.SetActive(inv);
        }


        if(paused || inv)
        {

            Time.timeScale = 0;

        }

        if(!paused && !inv)
        {

            Time.timeScale = 1;

        }



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