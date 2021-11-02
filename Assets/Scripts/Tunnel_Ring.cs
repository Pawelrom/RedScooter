using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel_Ring : MonoBehaviour
{
    [SerializeField] private float tunnelSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -tunnelSpeed);
    }


}
