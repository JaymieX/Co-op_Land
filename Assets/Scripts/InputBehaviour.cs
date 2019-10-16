using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputBehaviour : StateMachineBehaviour
{
    public abstract float HorizontalInput();

    public abstract float VerticalInput();
}
