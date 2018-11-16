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
    void Update()
    {
//        gameObject.transform.LookAt(new Vector3(transform.rotation.x, transform.rotation.y, 0.0f));
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0, Space.Self);
        transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0, Space.Self);
        if (transform.rotation.z > 0.0f)
        {
          //  Quaternion.AngleAxis(360.0f, new Vector3(0f, 0f, 1f));
//            transform.eulerAngles -= new Vector3(0,0,-transform.rotation.z);
            transform.rotation = Quaternion.Euler(0,0, transform.rotation.z );
        }

        if (transform.rotation.z < 0.0f)
        {
//            transform.eulerAngles += new Vector3(0,0,transform.rotation.z);
            transform.rotation = Quaternion.Euler(0,0, transform.rotation.z );
        }

        Debug.Log(transform.eulerAngles);
    }
}