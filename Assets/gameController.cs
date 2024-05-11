using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public MovementP2 player2sc;
    public PlayerController player1sc;

    public GameObject player1obj, player2obj, p1win, p2win, beraberewin, startpanel;

    // Update is called once per frame
    void Update()
    {
        if (player1obj.activeInHierarchy == false && player2obj.activeInHierarchy == false)
        {
            if (player2sc.scoreP2 > player1sc.score)
            {
                p2win.SetActive(true);
                Time.timeScale = 0f;
            }
            else if (player2sc.scoreP2 < player1sc.score)
            {
                p1win.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                beraberewin.SetActive(true);
                Time.timeScale = 0f;
            }

        }

    }


    public void gameStart()
    {
        Time.timeScale = 1f;
    }

    public void gamePause()
    {
        Time.timeScale = 0f;
    }

    public void gameResume()
    {
        Time.timeScale = 1f;
    }
    public void gameQuit()
    {
        Application.Quit();
    }
    public void gameRestart()
    {
        Time.timeScale = 1f;
        player2sc.player2.SetActive(true);
        player2sc.spawnerp2.SetActive(true);

        player1sc.player1.SetActive(true);
        player1sc.spawnerp1.SetActive(true);

        player1sc.score = 0;
        player2sc.scoreP2 = 0;

        SceneManager.LoadScene(0);
        startpanel.SetActive(false);

    }


}
