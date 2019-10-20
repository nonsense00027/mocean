using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject actionPanel;
    public GameObject actionButtons;
    public GameObject influencePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showAction()
    {
        actionPanel.SetActive(true);
        actionButtons.SetActive(true);
        influencePanel.SetActive(true);
    }
}
