using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Class11/Weapon Definition")]
public class WeaponDefinition : ItemDefinition
{
    public WeaponType weaponType;
    public float damage;
    public float cooldownDuration;
    public float range;
    
    public WeaponFiredEvent onWeaponFired;
}

public enum WeaponType
{
    Melee,
    Ranged,
    Magic
}

[System.Serializable]
public class WeaponFiredEvent : UnityEvent<WeaponRuntime> { }