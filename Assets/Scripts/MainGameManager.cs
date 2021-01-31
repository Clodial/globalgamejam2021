using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{

    public int Day { get; set; }
    public int Char1Overall { get; set; }
    public int Char1Curr { get; set; }
    public int Char2Overall { get; set; }
    public int Char2Curr { get; set; }
    public int Char3Overall { get; set; }
    public int Char3Curr { get; set; }
    public int photoIndex { get; set; }
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
