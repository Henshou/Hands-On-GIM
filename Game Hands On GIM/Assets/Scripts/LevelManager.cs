using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public string sceneName1;
    public string sceneName2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameScene()
    {
        SceneManager.UnloadSceneAsync ("Menu");
        SceneManager.LoadScene(sceneName1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StoryScene()
    {
        SceneManager.LoadScene(sceneName2);
    }
}
