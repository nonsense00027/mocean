using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    public GameObject ph;

    public void close()
    {
        ph.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
