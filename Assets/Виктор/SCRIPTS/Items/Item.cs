using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item/Item")]
public class Item : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
}