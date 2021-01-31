using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    Object[] myMusic;

    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(gameObject);
        myMusic = Resources.LoadAll<AudioClip>("Music");
        if (!GetComponent<AudioSource>().isPlaying)
        {
            playRandomMusic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
            playRandomMusic();
    }

    void playRandomMusic()
    {
        GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        GetComponent<AudioSource>().Play();
    }
}
