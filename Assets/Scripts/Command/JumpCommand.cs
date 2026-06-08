using UnityEngine;
using System.Collections;

public class JumpCommand : ICommand
{
    private readonly MonoBehaviour _runner;
    private readonly Transform _target;
    private readonly float _jumpScaleMultiplier;
    private readonly float _duration;

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
        Debug.Log($"Execute JumpCommand {_target.position}");
    }

    private IEnumerator JumpRoutine()
    {
        var originalScale = _target.localScale;
        var jumpScale = originalScale * _jumpScaleMultiplier;

        _target.localScale = jumpScale;

        yield return new WaitForSeconds(_duration);

        _target.localScale = originalScale;
    }

    public void Undo()
    {
        Debug.Log($"Undoing MoveCommand {_target.position}");
    }
}
