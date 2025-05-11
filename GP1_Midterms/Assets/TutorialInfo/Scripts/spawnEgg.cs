using System.Collections;
using UnityEngine;

public class spawnEgg : MonoBehaviour
{
    public GameObject Egg, Hen;
    public int minEgg = 1;
    public int maxEgg = 10;
    public float time = 3f;

    void Start()
    {
        StartCoroutine(SpawnEggs());
    }

    IEnumerator SpawnEggs()
    {
        yield return new WaitForSeconds(time);
        int eggNumber = Random.Range(minEgg, maxEgg + 1);
        Vector3 spawnUp = Hen.transform.position + Vector3.up * 1;

        for (int i = 0; i < eggNumber; i++)
        {
            Instantiate(Egg, spawnUp, Quaternion.identity);
            
        }
    }
}
