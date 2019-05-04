using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour {

    public Transform Target;
    public float SmoothSpeed = 1.125f;
    public Vector3 Offset;
    public bool stop=false;
    public Transform poscam;
    



    void FixedUpdate()
    {
        if (stop==false)
        {
            this.transform.position = poscam.transform.position;
            this.transform.LookAt(Target);
        }
        if (stop == true)
        {
            Vector3 DesiredPosition = Target.position + Offset;
            Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);
            transform.position = SmoothPosition;
            //transform.position = DesiredPosition;

            transform.LookAt(Target);
        }
    }
}
