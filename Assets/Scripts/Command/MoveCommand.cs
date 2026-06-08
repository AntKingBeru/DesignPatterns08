using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _target;
    private Vector3 _direction;
    private float _distance;

    public MoveCommand(Transform target, Vector3 direction, float distance)
    {
        _target = target;
        _direction = direction;
        _distance = distance;
    }

    public void Execute()
    {
        _target.position += _direction * _distance;
    }

    public void Undo()
    {
        _target.position -= _direction * _distance;
    }
}