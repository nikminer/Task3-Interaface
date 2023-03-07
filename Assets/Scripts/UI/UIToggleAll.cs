using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIToggleAll : MonoBehaviour
{
    public void SelectAll(bool isOn)
    {
        GetComponentInParent<UIPanel>().GetComponentsInChildren<UIItem>().Select(i => i.GetComponent<Toggle>()).Where(i => i.isOn == !isOn).ToList().ForEach(i => i.isOn = isOn);
    }

}
