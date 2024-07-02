
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButNpc : MonoBehaviour
{
    private float supposed_speed;
    private int travel_lane;
    public int car_sprite;
    public Sprite car1, car2, car3, car4, car5, car6, car7, car8, car9,
    car10, car11, car12, car13, car14, car15, car16, car17, car18;

    Rigidbody2D rb2d;
    SpriteRenderer spr;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();

        if (rb2d == null)
        {
            Debug.LogError("No Rigidbody2D attached to the game object. Please attach a Rigidbody2D component.");
            return; // Exit Start if no Rigidbody2D is found
        }

        travel_lane = Random.Range(1, 5);
        supposed_speed = Random.Range(2.5f, 3.5f);
        car_sprite = Random.Range(1, 19);

        switch (travel_lane)
        {
            case 1:
                transform.position = new Vector3(-1.44f, transform.position.y + 10, 0);
                break;
            case 2:
                transform.position = new Vector3(-0.5f, transform.position.y + 10, 0);
                break;
            case 3:
                transform.position = new Vector3(0.51f, transform.position.y + 10, 0);
                break;
            case 4:
                transform.position = new Vector3(1.46f, transform.position.y + 10, 0);
                break;
        }

        switch (car_sprite)
        {
            case 1:
                spr.sprite = car1;
                break;
            case 2:
                spr.sprite = car2;
                break;
            case 3:
                spr.sprite = car3;
                break;
            case 4:
                spr.sprite = car4;
                break;
            case 5:
                spr.sprite = car5;
                break;
            case 6:
                spr.sprite = car6;
                break;
            case 7:
                spr.sprite = car7;
                break;
            case 8:
                spr.sprite = car8;
                break;
            case 9:
                spr.sprite = car9;
                break;
            case 10:
                spr.sprite = car10;
                break;
            case 11:
                spr.sprite = car11;
                break;
            case 12:
                spr.sprite = car12;
                break;
            case 13:
                spr.sprite = car13;
                break;
            case 14:
                spr.sprite = car14;
                break;
            case 15:
                spr.sprite = car15;
                break;
            case 16:
                spr.sprite = car16;
                break;
            case 17:
                spr.sprite = car17;
                break;
            case 18:
                spr.sprite = car18;
                break;
        } // car's sprite control
    }

    void FixedUpdate()
    {
        if (rb2d != null)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, supposed_speed * 50 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "mainCar")
        {
            ScoreManager.SaveScore(); // Save the score before loading the crash scene
            SceneManager.LoadScene("CrashScene"); // Make sure the scene name matches
        }
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Overtaking")
        {
            ScoreManager.skor += 25;
        }
    }
}