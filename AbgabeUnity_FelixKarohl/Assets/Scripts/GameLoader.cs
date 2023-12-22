using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{

    /*public void StartGame()
        {
            SceneManager.LoadScene("Gameplay");
        }
    */

    public void QuitGame()
        {
            Application.Quit();
            Debug.Log("bye bye");
        } 

    /*
    public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MainMenu");
                Debug.Log("Auf zur scene");
            }
    }
    */

    [SerializeField]
    Image _loadingBar;

    IEnumerator LoadGameplay()
        {
            AsyncOperation loadGame = SceneManager.LoadSceneAsync("GamePlay");

            while (!loadGame.isDone)
            {
                _loadingBar.fillAmount = Mathf.Clamp01(loadGame.progress / .9f);
                yield return null;
            }
        Debug.Log("Ich passiere");
        }
   
    public void StartGame()
    {
        StartCoroutine(LoadGameplay());
    }
}