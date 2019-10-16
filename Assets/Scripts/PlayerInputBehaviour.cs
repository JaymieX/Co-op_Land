using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : InputBehaviour
{
    [SerializeField]
    private string horizontalAxis;
    [SerializeField]
    private string verticalAxis;

    public override float HorizontalInput()
    {
        return Input.GetAxis(horizontalAxis);
    }

    public override float VerticalInput()
    {
        return Input.GetAxis(verticalAxis);
    }
}
