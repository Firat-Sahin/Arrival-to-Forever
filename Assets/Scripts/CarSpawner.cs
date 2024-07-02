using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject random_car_npc;
    bool can_spawn = true;
    void Start()
    {
        StartCoroutine(wait());
    }


    IEnumerator wait()
    {
        while(can_spawn == true)
        {
            Instantiate(random_car_npc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
