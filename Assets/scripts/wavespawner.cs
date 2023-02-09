using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wavespawner : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI waveCountText;
    private int wavecount;
    private int enemycount;
    private float wavetexttimer = 1.0f;
    private float spawnrate = 1.0f;
    private float timesbetweenwaves = 5.0f;

    [SerializeField]
    private bool _iswaveactive = true;
    private bool _stopspawning = false;
    public GameObject[] enemies;
    public Transform[] SpawnPositions;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waveSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator waveSpawner()
    {
        while (_iswaveactive == true && _stopspawning == false)
        {
            Vector3 spawnPos = SpawnPositions[Random.Range(0, 5)].position;
            // Debug.Log(spawnPos);
            int randomEnemy = Probability_Random_num();
            Debug.Log(randomEnemy);
            _iswaveactive = false;
            for (int i = 0; i < enemycount; i++)
            {
                ActivateWaveText();
                yield return new WaitForSeconds(wavetexttimer);
                waveCountText.gameObject.SetActive(false);

                GameObject enemyClone = Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);
                yield return new WaitForSeconds(spawnrate);
                if (wavecount == 10)
                {
                    EndEnemyWaves();
                    yield return new WaitForSeconds(3f);
                    print("you win");
                }
            }
            spawnrate -= 1.0f;
            enemycount += 1;
            yield return new WaitForSeconds(timesbetweenwaves);
            wavecount += 1;
            _iswaveactive = true;
        }
    }
    public void EndEnemyWaves()
    {
        _stopspawning = true;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            GameObject.Destroy(enemy);
        }
    }
    private void ActivateWaveText()
    {
        waveCountText.text = "Wave: " + wavecount.ToString();
        waveCountText.gameObject.SetActive(true);

    }
    private int Probability_Random_num()
    {
        int x = Random.Range(0, 10);
        if (x <= 5)
        {
            return 0;
        }
        else if (x > 5 && x <= 8)
        {
            return 1;
        }
        return 2;
    }
}
