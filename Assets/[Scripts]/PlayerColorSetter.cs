using System;
using Mirage;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerColorSetter : NetworkBehaviour
{
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
    
    [ServerRpc]
    private void RequestSetColor(Color color)
    {
        // extra logic
        AcceptSetColor(color);
    }

    [ClientRpc]
    private void AcceptSetColor(Color color)
    {
        generatedColor = color;
        UpdateMaterialColor(generatedColor);
    }

    private void UpdateMaterialColor(Color color)
    {
        renderer.material.color = generatedColor;
    }
}
