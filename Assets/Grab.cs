using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private bool GrabObject = false;
    private string InteractText;
    public void OnInteract()
    {
        InteractText = "Press F to ";

        GrabObject = !GrabObject;
        InteractText += GrabObject ? "Use" : "Drop";

    }
}