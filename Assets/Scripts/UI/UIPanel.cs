using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public GameObject ScrollContent;
    public GameObject ItemPrefab;

    public ObjectGenerator ObjectGenerator;

    private void Start()
    {
        ObjectGenerator.OnGeneratedNewObj += ObjectGenerator_OnGeneratedNewObj;
    }

    private void ObjectGenerator_OnGeneratedNewObj(GameObject gameObject)
    {
        UIItem item = Instantiate(ItemPrefab, ScrollContent.transform).GetComponent<UIItem>();
        item.sceneObj = gameObject.GetComponent<SceneObj>();
    }

    public List<UIItem> GetSelectedItems()
    {
        return GetComponentsInChildren<UIItem>().Where(i => i.GetComponent<Toggle>().isOn).ToList();
    }
}
