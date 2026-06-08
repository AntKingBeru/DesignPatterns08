using UnityEngine;
using System.Collections.Generic;
public class CommandInvoker : MonoBehaviour
{
    private Stack<ICommand> _history = new Stack<ICommand>();
    private Stack<ICommand> _redoStack = new Stack<ICommand>();
    
    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void UndoLastCommand()
    {
        if (_history.Count == 0) return;
        _redoStack.Push( _history.Pop());
        _redoStack.Peek().Undo();
    }

    public void RedoLastUndo()
    {
        if (_redoStack.Count == 0) return;
        _history.Push( _redoStack.Pop()); 
        _history.Peek().Execute();
    }
}