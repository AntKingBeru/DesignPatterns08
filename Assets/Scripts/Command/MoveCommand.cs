using UnityEngine;

public class MoveCommand : ICommand
{
    private readonly Transform _target;
    private readonly Vector3 _direction;
    private readonly float _distance;

    public MoveCommand(Transform target, Vector2 direction, float distance)
    {
        _target = target;
        _direction = direction;
        _distance = distance;
    }

    public void Execute()
    {
        _target.position += _direction * _distance;
        Debug.Log($"Executing MoveCommand {_target.position}");
    }

    public void Undo()
    {
        _target.position -= _direction * _distance;
        Debug.Log($"Undoing MoveCommand {_target.position}");
    }
}