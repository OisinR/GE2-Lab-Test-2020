using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_RedState : RedState
{
    private Light trafficLight;

    public TR_RedState(Entity entity, FiniteStateMachine stateMachine, Light trafficLight) : base(entity, stateMachine)
    {
        this.trafficLight = trafficLight;
    }

    public override void Enter()
    {
        base.Enter();
        trafficLight.rendererL.material.color = Color.red;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(isRedTimeOver)
        {
            stateMachine.ChangeState(trafficLight.greenState);
        }
    }
}
