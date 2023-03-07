using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIHideAll : MonoBehaviour
{
    public void HideAll()
    {
        // ������ ��� �������� ��� ��������� ��������
        List<Toggle> items = GetComponentInParent<UIPanel>().GetSelectedItems().Select(i => i.GetComponentInChildren<UIToggleHide>().GetComponent<Toggle>()).ToList();
        if (items.Count == 0)
        {
            return;
        }

        // ����� �������� ������ ���������� ���������
        bool isOn = items.First().isOn;

        // ����� ����������� ���������� � ������������� �����
        items.ForEach(i => i.isOn = !isOn);

    }
}
