using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObj : MonoBehaviour
{
    public event Action OnDestoyObj = delegate { };

    private void OnDestroy()
    {
        OnDestoyObj();
    }

    public void SetOpacity(float a)
    {
        Material material = GetComponent<Renderer>().material;
        Color color = material.color;
        color.a = a;
        material.color = color;
    }
}
