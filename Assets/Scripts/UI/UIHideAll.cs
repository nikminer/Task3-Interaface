using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIHideAll : MonoBehaviour
{
    public void HideAll()
    {
        // Первый шаг получаем все выбранные элементы
        List<Toggle> items = GetComponentInParent<UIPanel>().GetSelectedItems().Select(i => i.GetComponentInChildren<UIToggleHide>().GetComponent<Toggle>()).ToList();
        if (items.Count == 0)
        {
            return;
        }

        // Затем получаем первый попавшееся состояние
        bool isOn = items.First().isOn;

        // Затем переключаем оставшееся в отрицательное этому
        items.ForEach(i => i.isOn = !isOn);

    }
}
