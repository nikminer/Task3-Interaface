using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public SceneObj sceneObj;

    private void Start()
    {
        sceneObj.OnDestoyObj += SelfDestruction;
        GetComponentInChildren<TextMeshProUGUI>().text = sceneObj.name;
    }

    private void OnDestroy()
    {
        sceneObj.OnDestoyObj -= SelfDestruction;
    }

    private void SelfDestruction()
    {
        Destroy(this.gameObject);
    }
}
