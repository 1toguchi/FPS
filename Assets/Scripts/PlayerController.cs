using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;

    [SerializeField] float _speed;

    [SerializeField] float _rotateSpeed;

    [SerializeField] GameObject _bullet;

    private void Update()
    {
        CharacterMoveUpdate();
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void CharacterMoveUpdate()
    {
        float moveHor =  _speed * Input.GetAxis("Horizontal");

        Vector3 forward = transform.transform.forward;
        Vector3 horizontal = transform.transform.right;

        float moveSpeed = _speed * Input.GetAxis("Vertical");


        _characterController.SimpleMove(forward * moveSpeed * Time.deltaTime);
        _characterController.SimpleMove(horizontal * moveHor * Time.deltaTime);

    }

    private void Shoot()
    {
        Ray ray = this.transform.root.Find("Camera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        Vector3 worldDir = ray.direction;

//        Vector3 pos = GameObject.Find("ShootPoint").transform.position;
//        Debug.Log(String.Format("pos is {0}", pos));
        GameObject b = Instantiate(_bullet, transform.position, Quaternion.identity);
        b.gameObject.GetComponent<Rigidbody>().AddForce(worldDir.normalized * 2000);
    }
}