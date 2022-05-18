using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayController : MonoBehaviour
{
    public CoinCollector coinCollector;
    public TextMeshProUGUI textComponent;
    public GameObject winMessage;
    
    private int totalCoinsCount;
    
    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(false);
        
        var allCoins = FindObjectsOfType<CoinTag>();
        totalCoinsCount = allCoins.Length;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = $"Coins collected: {coinCollector.collectedCoinsCount}/{totalCoinsCount}";
        
        bool isGameFinished = coinCollector.collectedCoinsCount >= totalCoinsCount;
        if (isGameFinished)
        {
            winMessage.SetActive(true);
        }
    }
}
