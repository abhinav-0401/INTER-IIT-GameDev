using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> enemy_prefabs;
    float time_stamp = 0.0f, time_gap = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > time_stamp){
            spawn();
        }
    }

    void spawn(){
        time_stamp = Time.time + time_gap;
        int random_Index = Random.Range(0, enemy_prefabs.Count);
        GameObject enemy = Instantiate(enemy_prefabs[random_Index], transform.position, Quaternion.identity);
    }
}
