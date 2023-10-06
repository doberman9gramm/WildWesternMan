using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class ShowComponents : MonoBehaviour
{
    private void OnValidate()
    {
        ShowAllComponents();
    }

    private void ShowAllComponents()
    {
        foreach (var item in GetComponents<Component>())
        {
            item.hideFlags = HideFlags.None;
        }
    }
}
