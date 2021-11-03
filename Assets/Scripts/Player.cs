using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject tunnelWall;
    [SerializeField] private GameObject parentForWall;
    private void OnTriggerEnter(Collider other)
    {
        var wall = Instantiate(tunnelWall, new Vector3(0, 0, 24), Quaternion.identity);
        wall.transform.parent = parentForWall.transform;
    }
}
