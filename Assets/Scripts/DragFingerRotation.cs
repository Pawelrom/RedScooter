using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerRotation : MonoBehaviour
{
    private Touch touch;
    private float speedModifier = 0.25f;
    private Quaternion rotationZ;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                rotationZ = Quaternion.Euler(
                    0f,
                    0f,
                    touch.deltaPosition.x * speedModifier);
                transform.rotation = rotationZ * transform.rotation;
            }
        } 
    }


}
