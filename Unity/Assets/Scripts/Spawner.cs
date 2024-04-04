using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToClone;

    // ????????????
    private void Start()
    {
        InvokeRepeating(nameof(Repeating), 1.0f, 1.0f);
    }

    private void Repeating()
    {
        //                                                    "default rotation"
        Object.Instantiate(objectToClone, transform.position, Quaternion.identity);
    }
}
