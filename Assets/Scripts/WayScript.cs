
using UnityEngine;

public class Wayscript : MonoBehaviour
{
    public GameObject way;
    bool way_made = false;

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "mainCar" && way_made == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            way_made = true;
            ScoreManager.skor += 10;
            Destroy(this.gameObject, 6f);
        }
    }
}
