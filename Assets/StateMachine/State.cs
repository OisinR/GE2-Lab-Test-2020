using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{

    protected FiniteStateMachine stateMachine;
    protected Light light;

    protected float startTime;


    public State(Light light, FiniteStateMachine stateMachine)
    {
        this.light = light;
        this.stateMachine = stateMachine;

    }

    public virtual void Enter()
    {
        startTime = Time.time;
    }

    public virtual void Exit()
    {

    }

    public virtual void LogicUpdate()
    {

    }


}