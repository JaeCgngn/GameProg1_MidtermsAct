using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
    public GameObject destroyOutside;

    void Update()
    {
        if (transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }
}
