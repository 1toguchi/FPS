using UnityEngine;

public class PlayerController : MonoBehaviour

{
    [SerializeField] CharacterController _characterController;
    [SerializeField] float _speed;
    [SerializeField] GameObject _bullet;

    private void Update()
    {
        CharacterMoveUpdate();
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
        
        GameObject.Find("Camera").transform.position = transform.position;
    }


    private void CharacterMoveUpdate()
    {
        float moveHor = _speed * Input.GetAxis("Horizontal");
        Vector3 forward = transform.transform.forward;
        Vector3 horizontal = transform.transform.right;
        float moveSpeed = _speed * Input.GetAxis("Vertical");

        _characterController.SimpleMove(forward * moveSpeed * Time.deltaTime);
        _characterController.SimpleMove(horizontal * moveHor * Time.deltaTime);
        
        GameObject camera = GameObject.Find("Camera");
        camera.transform.position = transform.position;
        camera.transform.rotation = transform.rotation;
        
    }


    private void Shoot()

    {
        Ray ray = transform.root.Find("Camera").GetComponent<Camera>().ScreenPointToRay(
            Input.mousePosition);
        Vector3 worldDir = ray.direction;

//        Vector3 pos = GameObject.Find("ShootPoint").transf    orm.position;
//        Debug.Log(String.Format("pos is {0}", pos));
        GameObject b = Instantiate(_bullet, transform.position, Quaternion.identity);

        b.gameObject.GetComponent<Rigidbody>().AddForce(worldDir.normalized * 2000);
    }
}