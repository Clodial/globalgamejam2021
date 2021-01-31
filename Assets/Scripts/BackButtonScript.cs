using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{

    public int sceneLoader;
    public int photoIndex;
    public bool isPhoto;

    private GameObject mainController;
    // Start is called before the first frame update
    void Start()
    {

        mainController = GameObject.Find("GameManager");

        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) =>
        {
            if (isPhoto)
            {
                mainController.GetComponent<MainGameManager>().photoIndex = this.photoIndex;
            }
            SceneManager.LoadScene(sceneLoader);
        });
        trigger.triggers.Add(entry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
