using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWalkingBehavior : StateMachineBehaviour
{
    PlayerMovement player;
    Transform _player;
    Enemy alien;
    Transform _alien;
    public float walkingSpeed;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (player == null)
        {
            player = FindObjectOfType<PlayerMovement>();
            _player = player.GetComponent<Transform>();
        }
        if (alien == null)
        {
            alien = FindObjectOfType<Enemy>();
            _alien = alien.GetComponent<Transform>();
            walkingSpeed = Enemy.walkingSpeed;
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _alien.transform.position = Vector2.Lerp(_alien.position, _player.position, walkingSpeed * Time.deltaTime);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
