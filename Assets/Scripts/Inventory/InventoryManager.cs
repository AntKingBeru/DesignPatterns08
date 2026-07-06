using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();
    public InventoryChangeEvent onInventoryChanged;

    public void AddItem(ItemDefinition def, int amount = 1)
    {
        var existing = items.Find(i => i.definition == def);
        if (existing != null)
            existing.quantity += amount;
        else
            items.Add(new InventoryItem(def, amount));

        onInventoryChanged?.Invoke(existing ?? items[^1], InventoryChangeType.Added);
    }

    public void RemoveItem(ItemDefinition def, int amount = 1)
    {
        var existing = items.Find(i => i.definition == def);
        if (existing == null)
            return;
        existing.quantity -= amount;
        var type = existing.quantity <= 0 ? InventoryChangeType.Removed : InventoryChangeType.QuantityChanged;
        if (existing.quantity <= 0)
            items.Remove(existing);
        onInventoryChanged?.Invoke(existing, type);
    }
}

public enum InventoryChangeType
{
    Added,
    Removed,
    QuantityChanged
}

[System.Serializable]
public class InventoryChangeEvent : UnityEvent<InventoryItem, InventoryChangeType> { }