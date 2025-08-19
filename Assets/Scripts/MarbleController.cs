using UnityEngine;

public class MarbleController : MonoBehaviour
{
    public float speed;
    Vector3 input;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // WASD, Arrow Keys, Controller stick
        input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.position += input * Time.deltaTime;
    }

    void FixedUpdate()
    {
        rb.AddForce(input * speed);
    }
} 