using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ICommand
{
    public void execute();

    public void undo();
}
