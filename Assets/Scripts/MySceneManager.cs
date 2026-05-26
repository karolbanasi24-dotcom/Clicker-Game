using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MySceneManager : MonoBehaviour
{   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
