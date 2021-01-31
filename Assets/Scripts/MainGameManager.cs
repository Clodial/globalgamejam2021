using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{

    private int Day { get; set; }
    private int Char1Overall { get; set; }
    private int Char1Curr { get; set; }
    private int Char2Overall { get; set; }
    private int Char2Curr { get; set; }
    private int Char3Overall { get; set; }
    private int Char3Curr { get; set; }
    public Queue photoAlbum;

    // Start is called before the first frame update
    void Start()
    {
        photoAlbum = new Queue();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
