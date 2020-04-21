using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowState : State
{


    protected bool isYellowTimeOver;
    protected float yellowTime;

    public YellowState(Entity entity, FiniteStateMachine stateMachine) : base(entity, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        isYellowTimeOver = false;
        yellowTime = 4;
    }

    public override void Exit()
    {
        base.Exit();

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Time.time >= startTime + yellowTime)
        {
            isYellowTimeOver = true;
        }
    }

}