using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel_Ring : MonoBehaviour
{
    [SerializeField] private float tunnelSpeed = 1f;
    
    //Placements
    [SerializeField] private GameObject[] trapsPlacements;
    [SerializeField] private GameObject[] traps;

    private void OnEnable()
    {
        int RandomPlaceOnWall = Random.Range(0, trapsPlacements.Length);
        Vector3 TrapsPosition = trapsPlacements[RandomPlaceOnWall].transform.position;

        int RandomTrapOnWall = Random.Range(0, traps.Length);

        var trap = Instantiate(traps[RandomTrapOnWall], TrapsPosition, trapsPlacements[RandomPlaceOnWall].transform.rotation, trapsPlacements[RandomPlaceOnWall].transform);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -tunnelSpeed);
    }


}
