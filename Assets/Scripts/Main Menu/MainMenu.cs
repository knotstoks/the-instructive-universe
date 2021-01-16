using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
        
    public GameObject greyBackground, playButton, optionsButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void disableWindow(GameObject window) {
        window.SetActive(false);
        greyBackground.SetActive(false);
    }

    public void enableWindow(GameObject window) {
        window.SetActive(true);
        greyBackground.SetActive(true);
    }
}
