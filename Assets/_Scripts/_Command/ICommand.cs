using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Abstract Command Interface
public interface ICommand
{
    void Execute();

    void Undo();
}
