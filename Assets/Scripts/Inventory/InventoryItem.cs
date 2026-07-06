using System;

[Serializable]
public class InventoryItem
{
    public ItemDefinition definition;
    public int quantity;

    public InventoryItem(ItemDefinition definition, int quantity = 1)
    {
        this.definition = definition;
        this.quantity = quantity;
    }
}