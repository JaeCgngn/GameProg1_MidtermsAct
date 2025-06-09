using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI eggText;
    [SerializeField] private TextMeshProUGUI chickText;
    [SerializeField] private TextMeshProUGUI henText;
    [SerializeField] private TextMeshProUGUI roosterText;

    void Update()
    {
        int eggs = GameObject.FindGameObjectsWithTag("egg").Length;
        int chicks = GameObject.FindGameObjectsWithTag("chick").Length;
        int hens = GameObject.FindGameObjectsWithTag("hen").Length;
        int roosters = GameObject.FindGameObjectsWithTag("rooster").Length;

        eggText.SetText("{0}", eggs);
        chickText.SetText("{0}", chicks);
        henText.SetText("{0}", hens);
        roosterText.SetText("{0}", roosters);
    }
}