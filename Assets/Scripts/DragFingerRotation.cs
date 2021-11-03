using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerRotation : MonoBehaviour
{
    private Touch touch;
    private float speedModifier = 0.07f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                Quaternion deltaQuaternionRot = Quaternion.AngleAxis(transform.rotation.z + touch.deltaPosition.x * speedModifier, Vector3.forward);
                transform.rotation = transform.rotation * deltaQuaternionRot;
            }
        } 
    }


}
