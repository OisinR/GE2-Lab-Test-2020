using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : Entity
{

    public GreenState greenState { get; private set; }
    public YellowState yellowState { get; private set; }
    public RedState redState { get; private set; }

   

    public override void Start()
    {
        base.Start();

        greenState = new GreenState(this, stateMachine);
        yellowState = new YellowState(this, stateMachine);
        redState = new RedState(this, stateMachine);

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
