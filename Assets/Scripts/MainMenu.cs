using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private MySceneManager mySceneManager;
    [SerializeField] private Button QuitButton;
    [SerializeField] private Button PlayButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mySceneManager = GetComponent<MySceneManager>();
        QuitButton.onClick.AddListener(mySceneManager.GameQuit);
        PlayButton.onClick.AddListener(mySceneManager.LoadGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
