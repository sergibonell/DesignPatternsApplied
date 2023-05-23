using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private GameObject _piece;
    private Vector2 _movement;

    public MoveCommand(GameObject piece, Vector2 movement)
    {
        _piece = piece;
        _movement = movement;
    }

    public void execute()
    {
        _piece.transform.position += new Vector3(_movement.x, _movement.y, 0);
    }

    public void undo()
    {
        _piece.transform.position -= new Vector3(_movement.x, _movement.y, 0);
    }
}
