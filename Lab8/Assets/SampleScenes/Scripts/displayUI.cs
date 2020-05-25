using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{
    public GameObject displayingInf;

    // Start is called before the first frame update
    void Start()
    {
        displayingInf.SetActive(false);
    }

    private void OnMouseExit()
    {
        displayingInf.SetActive(false);
    }

    private void OnMouseOver()
    {
        displayingInf.SetActive(true);
    }
}
