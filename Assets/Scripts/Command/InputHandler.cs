using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Transform player;
    // [SerializeField] private CommandInvoker invoker;
    
    [Header("Input")]
    [SerializeField] private InputActionReference move;
    [SerializeField] private InputActionReference jump;
    [SerializeField] private InputActionReference undo;
    [SerializeField] private InputActionReference redo;

    private ICommand _forwardCommand;
    private ICommand _backCommand;
    private ICommand _leftCommand;
    private ICommand _rightCommand;
    private ICommand _jumpCommand;

    private void OnEnable()
    {
        move.action.Enable();
        jump.action.Enable();
        undo.action.Enable();
        redo.action.Enable();
    }

    private void OnDisable()
    {
        move.action.Disable();
        jump.action.Disable();
        undo.action.Disable();
        redo.action.Disable();
    }

    private void Start()
    {
        _forwardCommand = new MoveCommand(player, Vector2.up, 1f);
        _backCommand = new MoveCommand(player, Vector2.down, 1f);
        _leftCommand = new MoveCommand(player, Vector2.left, 1f);
        _rightCommand = new MoveCommand(player, Vector2.right, 1f);
        _jumpCommand = new JumpCommand(this, player, 2f, 0.5f);
    }

    private void Update()
    {
        var moveX = move.action.ReadValue<Vector2>().x;
        var moveY = move.action.ReadValue<Vector2>().y;
        switch (moveX)
        {
            case > 0:
                // invoker.ExecuteCommand(_rightCommand);
                break;
            case < 0:
                // invoker.ExecuteCommand(_leftCommand);
                break;
        }

        switch (moveY)
        {
            case > 0:
                // invoker.ExecuteCommand(_forwardCommand);
                break;
            case < 0:
                // invoker.ExecuteCommand(_backCommand);
                break;
        }
        // if (jump.action.triggered)
        //     invoker.ExecuteCommand(_jumpCommand);
        
        // if (undo.action.triggered)
        //     invoker.UndoLastCommand();
        // if (redo.action.triggered)
        //     invoker.RedoLastUndo();
    }
}