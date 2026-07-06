using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Class11/Item Definition")]
public class ItemDefinition : ScriptableObject
{
    public string itemId;
    public string displayName;
    public int maxStackSize = 1;
    public bool isUsable = true;
    
    public ItemUsedEvent onItemUsed;
}

[System.Serializable]
public class ItemUsedEvent : UnityEvent<ItemDefinition> { }