using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light Spotlight;

    private void OnTriggerEnter(Collider other)
    {
        Spotlight.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Spotlight.enabled = false;
    }

    private void Update()
    {
        Spotlight.intensity = Mathf.Sin(Time.time * 10) * 100;
    }
}
