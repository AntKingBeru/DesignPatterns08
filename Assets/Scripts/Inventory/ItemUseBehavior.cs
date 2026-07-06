using UnityEngine;

public class ItemUseBehavior : MonoBehaviour
{
    public InventoryManager inventory;
    public WeaponBehavior weaponBehavior;
    
    public void UseItem(InventoryItem item)
    {
        if (!item?.definition || !item.definition.isUsable)
            return;

        if (item.definition is WeaponDefinition weaponDef)
        {
            weaponBehavior.Equip(weaponDef);
            item.definition.onItemUsed?.Invoke(item.definition);
            return;
        }
        
        item.definition.onItemUsed?.Invoke(item.definition);
        inventory.RemoveItem(item.definition);
    }
}