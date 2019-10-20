using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public GameObject phil;
    public GameObject info;
    public void showInfo()
    {
        info.SetActive(true);
        phil.SetActive(true);
    }
}
