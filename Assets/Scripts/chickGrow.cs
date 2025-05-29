using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickGrow : MonoBehaviour
{
    public GameObject chick, hen, rooster;

    public float time = 3f;
    public static bool firstGrow = true;

    void Start()
    {
        StartCoroutine(chickToHen());
    }

    IEnumerator chickToHen()
    {
        yield return new WaitForSeconds(time);

        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        GameObject randomGrow;

        if (firstGrow)
        {
            randomGrow = hen;
            firstGrow = false;
        }
        else if (Random.value < 0.5f)
        {
            randomGrow = hen;
        }
        else
        {
            randomGrow = rooster;
        }

        Destroy(gameObject);
        Instantiate(randomGrow, position, rotation);

    }


}
