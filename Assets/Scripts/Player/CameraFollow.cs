using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, -10f);

        //transform.position = vector3.lerp(transform.position, desiredposition, smoothspeed * time.deltatime);

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }
}
