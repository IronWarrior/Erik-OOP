using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    int startingResources = 3;

    [SerializeField]
    int startingLives = 10;

    private int currentResources;
    private int currentLives;

    private void Awake()
    {
        currentResources = startingResources;
        currentLives = startingLives;
    }

    public bool HasResources()
    {
        return currentResources > 0;
    }

    public void SpendResource()
    {
        currentResources -= 1;

        Debug.Log($"Resources reduced to {currentResources}");
    }

    public void AcquireResource()
    {
        currentResources += 1;

        Debug.Log($"Resources increased to {currentResources}");
    }

    public void TakeLife()
    {
        currentLives -= 1;

        Debug.Log($"Lives reduced to {currentLives}");
    }
}
