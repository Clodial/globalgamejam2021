using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosDisplayScript : MonoBehaviour
{

    private GameObject mainController;
    public int photoIndex;

    // Start is called before the first frame update
    void Start()
    {
        mainController = GameObject.Find("GameManager");
        mainController.GetComponent<MainGameManager>().photoIndex = this.photoIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
