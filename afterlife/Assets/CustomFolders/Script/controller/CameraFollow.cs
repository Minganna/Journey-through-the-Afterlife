using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform Target;
    public float SmoothSpeed=1.125f;
    public Vector3 Offset;

    void FixedUpdate ()
    {
        Vector3 DesiredPosition = Target.position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed*Time.deltaTime);
        transform.position = SmoothPosition;

        transform.LookAt(Target);
    }
}
