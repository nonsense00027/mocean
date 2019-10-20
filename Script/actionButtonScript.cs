using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionButtonScript : MonoBehaviour
{
    public GameObject actionPanel;
    public GameObject influencePanel;
    public GameObject preventionPanel;
    public GameObject movementPanel;
    public GameObject info;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void influence()
    {
        influencePanel.SetActive(true);
        preventionPanel.SetActive(false);
        movementPanel.SetActive(false);
        info.SetActive(false);
    }

    public void prevent()
    {
        influencePanel.SetActive(false);
        preventionPanel.SetActive(true);
        movementPanel.SetActive(false);
        info.SetActive(false);
    }

    public void movement()
    {
        influencePanel.SetActive(false);
        preventionPanel.SetActive(false);
        movementPanel.SetActive(true);
        info.SetActive(false);
    }


    public void close()
    {
        actionPanel.SetActive(false);
        influencePanel.SetActive(false);
        preventionPanel.SetActive(false);
        movementPanel.SetActive(false);
        this.gameObject.SetActive(false);
        info.SetActive(false);
    }
}
