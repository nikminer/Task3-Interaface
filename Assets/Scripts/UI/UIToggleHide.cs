using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggleHide : MonoBehaviour
{
    private UIItem _UIItem;
    private Toggle _toggle;
    private void Start()
    {
        _UIItem = GetComponentInParent<UIItem>();

        _toggle = GetComponentInChildren<Toggle>();
        _toggle.isOn = _UIItem.sceneObj.gameObject.activeSelf;
    }
    public void HideShow(bool show)
    {
        _UIItem.sceneObj.gameObject.SetActive(show);
    }
}
