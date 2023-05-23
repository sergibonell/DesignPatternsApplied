using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Stack<ICommand> commands = new Stack<ICommand>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            _move(1, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            _move(-1, 0);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            _move(0, 1);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            _move(0, -1);

        if (Input.GetKeyDown(KeyCode.Backspace) && commands.Count > 0)
            commands.Pop().undo();
    }

    private void _move(int x, int y)
    {
        ICommand c = new MoveCommand(gameObject, new Vector2(x, y));
        c.execute();
        commands.Push(c);
    }
}
