using System;
using Mirage;
using UnityEngine;

public class CoinCollector : NetworkBehaviour
{
    public int collectedCoinsCount = 0;
    public NetworkManager networkManager;
    
    private void Start()
    {
        networkManager = FindObjectOfType<NetworkManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.gameObject.name);

        CoinTag coinTag = other.gameObject.GetComponent<CoinTag>();
        bool isCoin = (coinTag != null);

        if (isCoin && IsServer)
        {
            networkManager.ServerObjectManager.Destroy(other.gameObject);
            collectedCoinsCount++;
        }
    }
}
