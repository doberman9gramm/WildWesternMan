using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;
using System;

[RequireComponent(typeof(Animator))]
public class AnimatorFSM : MonoBehaviour
{
    [SerializeField] private StateMachine stateMachine;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        stateMachine.NewState += ChangeAnimation;
    }

    private void OnDisable()
    {
        stateMachine.NewState -= ChangeAnimation;
    }

    private void ChangeAnimation(State state)
    {
        //animator.
    }
}