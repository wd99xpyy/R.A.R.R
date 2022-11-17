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
    public GameObject map;
    public GameObject directory;
    public bool myBagIsOpen;
    public bool mapIsOpen;
    public bool directoryIsOpen;

    // Start is called before the first frame update
    void Start()
    {
        theCamera = GameObject.Find("MainCamera").GetComponent<Camera>();

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
