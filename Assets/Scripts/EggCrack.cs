using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCrack : MonoBehaviour
{
    public GameObject Egg, Chick;
    public float time = 3f;

    void Start()
    {
        StartCoroutine(crackEgg());
    }

    IEnumerator crackEgg()
    {
        yield return new WaitForSeconds(time);

        Vector3 position = Egg.transform.position;
        Quaternion rotation = Egg.transform.rotation;

        Destroy(Egg.gameObject);
        Instantiate(Chick, position, rotation);
    }
}
