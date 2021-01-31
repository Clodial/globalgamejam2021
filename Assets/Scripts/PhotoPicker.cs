using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPicker : MonoBehaviour
{

    private GameObject mainController;
    public GameObject photoImage;
    private int photoIndex;

    // Start is called before the first frame update
    void Start()
    {
        mainController = GameObject.Find("GameManager");
        photoIndex = mainController.GetComponent<MainGameManager>().photoIndex;

        Debug.Log(photoIndex);

        Texture incomingTexture = LoadImageFile(photoIndex);
        photoImage.GetComponent<RawImage>().texture = incomingTexture;
    }

    // Update is called once per frame
    void Update()
    {

    }

    Texture LoadImageFile(int index)
    {
        if (index == 0)
        {
            return Resources.Load<Texture>("Art/question-box");
        }
        else if (index == 1)
        {
            return Resources.Load<Texture>("Art/pom");
        }
        else if (index == 2)
        {
            return Resources.Load<Texture>("Art/coffee");
        }
        else
        {
            return Resources.Load<Texture>("Art/hands");
        }
    }
}
