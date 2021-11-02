using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stary blok umiera");
    }
}
