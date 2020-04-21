using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedState : State
{


    protected bool isGreenTimeOver;
    protected float greenTime;

    public RedState(Entity entity, FiniteStateMachine stateMachine) : base(entity, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        isGreenTimeOver = false;
        SetRandomGreenTime();
    }

    public override void Exit()
    {
        base.Exit();

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Time.time >= startTime + greenTime)
        {
            isGreenTimeOver = true;
        }
    }

    private void SetRandomGreenTime()
    {
        greenTime = Random.Range(5, 10);
    }
}