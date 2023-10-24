using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item")]
public abstract class Item : ScriptableObject
{
    public string Name;
}