using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrickCommand : ICommand
{
    Vector3 position;
    Transform item;

    public DestroyBrickCommand(Vector3 position, Transform item)
    {
        this.position = position;
        this.item = item;
    }
    public void Execute()
    {
        BrickDestroyer.DestroyItem(position);
    }

    public void Undo()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
