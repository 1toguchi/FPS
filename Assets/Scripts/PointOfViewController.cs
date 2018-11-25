using UnityEngine;

public class PointOfViewController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _rotate;

    void Update()
    {
//        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
//        transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0);
//        transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, 0.0f);

        _rotate += new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * _speed;
        transform.rotation = Quaternion.Euler(_rotate);
    }
}