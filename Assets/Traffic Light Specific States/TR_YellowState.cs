using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_YellowState : YellowState
{
    private TrafficLight trafficLight;

    public TR_YellowState(Light light, FiniteStateMachine stateMachine, TrafficLight trafficLight) : base(light, stateMachine)
    {
        this.trafficLight = trafficLight;
    }

    public override void Enter()
    {
        base.Enter();
        trafficLight.rendererL.material.color = Color.yellow;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(isYellowTimeOver)
        {
            stateMachine.ChangeState(trafficLight.redState);
        }
    }
}
