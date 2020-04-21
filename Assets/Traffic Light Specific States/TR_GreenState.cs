using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_GreenState : GreenState
{
    private Light trafficLight;

    public TR_GreenState(Entity entity, FiniteStateMachine stateMachine, Light trafficLight) : base(entity, stateMachine)
    {
        this.trafficLight = trafficLight;
    }

    public override void Enter()
    {
        base.Enter();
        trafficLight.rendererL.material.color = Color.green;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(isGreenTimeOver)
        {
            stateMachine.ChangeState(trafficLight.yellowState);
        }
    }
}
