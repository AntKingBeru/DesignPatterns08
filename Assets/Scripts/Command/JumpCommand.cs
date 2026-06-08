using UnityEngine;
using System.Collections;

public class JumpCommand : ICommand
{
    private MonoBehaviour _runner;
    private Transform _target;
    private float _jumpScaleMultiplier;
    private float _duration;

    public JumpCommand(MonoBehaviour runner, Transform target, float jumpScaleMultiplier, float duration)
    {
        _runner = runner;
        _target = target;
        _jumpScaleMultiplier = jumpScaleMultiplier;
        _duration = duration;
    }

    public void Execute()
    {
        _runner.StartCoroutine(JumpRoutine());
    }

    private IEnumerator JumpRoutine()
    {
        Vector3 originalScale = _target.localScale;
        Vector3 jumpScale = originalScale * _jumpScaleMultiplier;

        _target.localScale = jumpScale;

        yield return new WaitForSeconds(_duration);

        _target.localScale = originalScale;
    }

    public void Undo()
    {
    }
}
