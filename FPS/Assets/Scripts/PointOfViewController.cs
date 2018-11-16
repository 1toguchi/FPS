using UnityEngine;

public class PointOfViewController : MonoBehaviour
{
    Transform _verRot;
    Transform _horRot;


    // Use this for initialization
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0, Space.Self);
        transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0, Space.Self);
    }
}