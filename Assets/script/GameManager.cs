using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentLocation = 0;
    public GameObject background;
    public Sprite[] backgroundImage;
    public Camera theCamera;

    public GameObject myBag;
    public GameObject device;
    public GameObject map;
    public GameObject directory;
    public GameObject introMessage;
    public bool introMessageIsOpen;
    public bool deviceIsOpen;
    public bool myBagIsOpen;
    public bool mapIsOpen;
    public bool directoryIsOpen;

    // Start is called before the first frame update
    void Start()
    {
        theCamera = GameObject.Find("MainCamera").GetComponent<Camera>();

        StartCoroutine(showIntroMessage(3));

    }

    IEnumerator showIntroMessage(float duration)
    { 
        // waits here
        yield return new WaitForSeconds(duration);
        introMessage.SetActive(introMessageIsOpen);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OpenMyBag();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            OpenMap();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            OpenDirectory();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            OpenDevice();
        }

    }

     public void OpenIntroMessage()
    {
        introMessageIsOpen = !introMessageIsOpen;
        introMessage.SetActive(introMessageIsOpen);
    }
     public void OpenDevice()
    {
        deviceIsOpen = !deviceIsOpen;
        device.SetActive(deviceIsOpen);
    }
    public void OpenMyBag()
    {
        myBagIsOpen = !myBagIsOpen;
        myBag.SetActive(myBagIsOpen);
    }
    public void OpenMap()
    {
        mapIsOpen = !mapIsOpen;
        map.SetActive(mapIsOpen);
    }

    public void OpenDirectory()
    {
        directoryIsOpen = !directoryIsOpen;
        directory.SetActive(directoryIsOpen);
    }
    public void LoadLocation(int locationNum)
    {
        background.GetComponent<SpriteRenderer>().sprite = backgroundImage[locationNum];
        currentLocation = locationNum;
        theCamera.transform.position = new Vector3(-20, -50 * locationNum, -10);
        OpenMap();
    }
}
