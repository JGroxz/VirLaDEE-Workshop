using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int collectedCoinsCount = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.gameObject.name);

        CoinTag coinTag = other.gameObject.GetComponent<CoinTag>();
        bool isCoin = (coinTag != null);

        if (isCoin)
        {
            other.gameObject.SetActive(false);
            collectedCoinsCount++;
        }
    }
}
