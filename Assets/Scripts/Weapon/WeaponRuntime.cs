using System;

[Serializable]
public class WeaponRuntime
{
    public WeaponDefinition definition;
    public float currentCooldown;
    public int currentAmmo;

    public bool IsReady => currentCooldown <= 0f;

    public void Tick(float deltaTime)
    {
        if (currentCooldown > 0f)
            currentCooldown -= deltaTime;
    }

    public void TriggerCooldown()
        => currentCooldown = definition.cooldownDuration;
}