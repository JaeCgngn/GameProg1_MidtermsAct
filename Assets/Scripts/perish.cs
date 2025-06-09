using System.Collections;
using UnityEngine;

public class perish : MonoBehaviour
{
    public GameObject Rooster, Hen;
    public float time = 40f;

    void Start()
    {
        StartCoroutine(perishEnd());
    }

    IEnumerator perishEnd()
    {
        yield return new WaitForSeconds(time);

        Destroy(Hen);
        Destroy(Rooster);
    }
}