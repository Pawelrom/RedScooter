using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerRotation : MonoBehaviour
{
    private Touch touch;
    private float speedMod = 0.001f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                transform.rotation = new Quaternion(
                    transform.rotation.x,
                    transform.rotation.y,
                    transform.rotation.z + touch.deltaPosition.x * speedMod,
                    transform.rotation.w
                    );
            }
        } 
    }


}
