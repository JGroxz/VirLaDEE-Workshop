using System;
using Mirage;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerColorSetter : NetworkBehaviour
{
    [SyncVar]
    public Color generatedColor;

    public float from = 0.3f;
    public float to = 0.8f;

    public MeshRenderer renderer;

    public Color GetRandomColor()
    {
        return new Color
        {
            r = Random.Range(from, to),
            g = Random.Range(from, to),
            b = Random.Range(from, to),
            a = 1
        };
    }

    private void Start()
    {
        // generatedColor = GetRandomColor();
        if (IsLocalPlayer) RequestSetColor(generatedColor);
    }

    private void Update()
    {
        UpdateMaterialColor(generatedColor);
    }

    [ServerRpc]
    private void RequestSetColor(Color color)
    {
        generatedColor = color;
    }

    private void UpdateMaterialColor(Color color)
    {
        renderer.material.color = generatedColor;
    }
}
