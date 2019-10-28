using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject shootingPlayer;
    // Start is called before the first frame update

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        shootingPlayer.GetComponent<Weapon>().enabled = true;

    }

    private void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        shootingPlayer.GetComponent<Weapon>().enabled = false;

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("I quit!");
    }
}
