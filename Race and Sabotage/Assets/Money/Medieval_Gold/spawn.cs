using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    /*Timing and Spawn places */
    public Vector3 spawnValues;
    public float spawnWait;
    public float startWait;

    /* Coin prefab */
    public GameObject coin;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(startWait);
            //Instantiating food at random place with some random flux
            Vector3 spawnPosition = new Vector3
                (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject newCoin = Instantiate(coin, spawnPosition, spawnRotation);
            newCoin.transform.localScale = new Vector3(1000f, 1000f, 1000f);
            newCoin.transform.SetParent(transform, false);
            newCoin.GetComponent<Mover>().setSpeed(-0.0001f);
            newCoin.GetComponent<BoxCollider>().enabled = false;
            newCoin.GetComponent<Rigidbody>().useGravity = false;
            newCoin.GetComponent<Rigidbody>().AddForce(new Vector3(0f, -1000f, 0f));
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
