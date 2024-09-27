using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhenHittingAnObject : MonoBehaviour
{
    [SerializeField] private List<Color> PossibleColors = new List<Color>();

    [SerializeField] private bool UsePredefinedColors = true;
    
    private Material myMaterial = null;
    
    private void Start()
    {
        myMaterial = GetComponent<MeshRenderer>().material;
    }

    private void OnCollisionEnter(Collision other)
    {
        Color ColorToUse;
        if (UsePredefinedColors)
        {
            ColorToUse = PossibleColors[UnityEngine.Random.Range(0, PossibleColors.Count - 1)];
        }
        else
        {
            ColorToUse = new Color
                (
                    UnityEngine.Random.Range(0.0f, 1.0f),
                    UnityEngine.Random.Range(0.0f, 1.0f),
                    UnityEngine.Random.Range(0.0f, 1.0f),
                    1.0f
                );
        }
        

        myMaterial.SetColor
            (
                "_Color", 
                ColorToUse
            );
    }
}
