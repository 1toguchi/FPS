using UnityEngine;

public class PointOfViewController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0);
        transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, 0.0f);
    }
}