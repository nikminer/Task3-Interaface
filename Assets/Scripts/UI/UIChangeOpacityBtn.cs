using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeOpacityBtn : MonoBehaviour
{
    public float Opacity;

    public void ChangeOpacity()
    {
        GetComponentInParent<UIPanel>().GetSelectedItems().ForEach(i => i.sceneObj.SetOpacity(Opacity));
    }
}
