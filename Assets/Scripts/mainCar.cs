
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float vertical_speed, horizontal_speed, supposed_speed;
    private float vertical_movement, horizontal_movement;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

   
    void FixedUpdate()
    {
        vertical_movement = Input.GetAxis("Vertical");
        horizontal_movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3
        (horizontal_movement * 50 * horizontal_speed * Time.deltaTime, supposed_speed + vertical_movement * 50 * vertical_speed * Time.deltaTime);

        if(transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;

        } // right border control

        if (transform.position.x < -1.82f)
        {
            Vector3 left_limit = new Vector3(-1.82f, transform.position.y);
            transform.position = left_limit;
        } // left border control
    }
}
