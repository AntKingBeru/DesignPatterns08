using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    public WeaponRuntime runtime = new WeaponRuntime();
    public Transform muzzlePoint;

    public void Equip(WeaponDefinition definition)
    {
        runtime.definition = definition;
        runtime.currentCooldown = 0f;
    }

    private void Update()
    {
        if (runtime.definition)
            runtime.Tick(Time.deltaTime);
    }

    public void TryFire()
    {
        if (!runtime.definition || !runtime.IsReady)
            return;

        runtime.TriggerCooldown();
        runtime.definition.onWeaponFired?.Invoke(runtime);
    }
    
    [ContextMenu("Test Fire")]
    private void TestFire() => TryFire();
}