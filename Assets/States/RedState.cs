using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedState : State
{


    protected bool isRedTimeOver;
    protected float redTime;

    public RedState(Entity entity, FiniteStateMachine stateMachine) : base(entity, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        isRedTimeOver = false;
        SetRandomRedTime();
    }

    public override void Exit()
    {
        base.Exit();

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Time.time >= startTime + redTime)
        {
            isRedTimeOver = true;
        }
    }

    private void SetRandomRedTime()
    {
        redTime = Random.Range(5, 10);
    }
}