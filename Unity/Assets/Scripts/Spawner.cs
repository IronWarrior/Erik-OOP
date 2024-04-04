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
        //                                                      an "identity" is some value (A), which when multiplied
        //                                                      by a second value (B), results in B.
        Object.Instantiate(objectToClone, transform.position, Quaternion.identity);
    }
}
