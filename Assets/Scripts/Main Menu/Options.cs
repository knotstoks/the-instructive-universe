using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public AudioSource music;
    public Slider music_vol;
    public static float vol = 1;


    // Start is called before the first frame update
    void Start()
    {
        music_vol.onValueChanged.AddListener(delegate {changeVol(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVol() {
        music.volume = music_vol.value;
    }
}
