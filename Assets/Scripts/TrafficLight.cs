using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : Light
{

    public TR_GreenState greenState { get; private set; }
    public TR_YellowState yellowState { get; private set; }
    public TR_RedState redState { get; private set; }

    public Renderer rendererL;

    public override void Start()
    {
        base.Start();

        rendererL = GetComponent<Renderer>();

        greenState = new TR_GreenState(this, stateMachine, this);
        yellowState = new TR_YellowState(this, stateMachine, this);
        redState = new TR_RedState(this, stateMachine, this);

        RandomiseAtStart();
    }

    public override void Update()
    {
        base.Update();
    }


    void RandomiseAtStart()
    {
        float randomiser = Random.Range(0, 3);

        switch(randomiser)
        {
            case 0:
                stateMachine.Initialize(greenState);
                break;

            case 1:
                stateMachine.Initialize(yellowState);
                break;

            case 2:
                stateMachine.Initialize(redState);
                break;
        }
    }
}
