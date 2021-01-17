using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public float currentTime;
    public float startTime;
    public Text countdownText;
    public Image strike1;
    public Image strike2;

    private PlayerData playerData;

    void Awake() 
    {
        playerData = GameObject.FindObjectOfType<PlayerData>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        strike1.canvasRenderer.SetAlpha(0.5f);
        strike2.canvasRenderer.SetAlpha(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (playerData.strikes == 1) {
            strike1.canvasRenderer.SetAlpha(1.0f);
        } 

        if (playerData.strikes == 2) {
            strike2.canvasRenderer.SetAlpha(1.0f);
        }
    }


    
}
