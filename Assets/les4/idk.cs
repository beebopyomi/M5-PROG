using UnityEngine;

public class idk : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 100f;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private bullet bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, horizontalInput * Time.deltaTime * rotateSpeed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
    {
        bullet bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        bullet.direction = transform.right;
    }
    }
}
