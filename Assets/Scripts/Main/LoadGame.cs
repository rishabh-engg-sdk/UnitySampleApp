using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    Button loadGameButton;

    private void Awake()
    {
        loadGameButton = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        loadGameButton.onClick.AddListener(LoadGameScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
    
}
