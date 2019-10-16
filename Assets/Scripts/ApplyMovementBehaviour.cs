using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMovementBehaviour : StateMachineBehaviour
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        InputBehaviour input = animator.GetBehaviour<InputBehaviour>();

        float horizontal = input.HorizontalInput();
        float vertical = input.VerticalInput();
        float speed = animator.GetComponent<CreatureController>().CreatureDataObject.SpeedPerSecond;

        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;

        animator.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(movement * speed * Time.deltaTime);
    }
}
