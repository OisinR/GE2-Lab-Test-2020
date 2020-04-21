using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_GreenState : GreenState
{
    private TrafficLight trafficLight;

    public TR_GreenState(Light light, FiniteStateMachine stateMachine, TrafficLight trafficLight) : base(light, stateMachine)
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
