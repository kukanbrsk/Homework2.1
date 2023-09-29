using UnityEngine;

public class WorkState : IState
{
    private readonly IStateSwitcher _stateSwitcher;
    private readonly StateMachineData _data;
    private readonly Character _character;

    public WorkState(CharacterStateMachine characterStateMachine, StateMachineData data, Character character)
    {
        _stateSwitcher = characterStateMachine;
        _data = data;
        _character = character;
    }

    public void Enter()
    {
        Debug.Log("NPC начал работу");
    }

    public void Update()
    {
        _stateSwitcher.SwitchState<WalkState>();
    }

    public void Exit()
    {
        Debug.Log("NPC закончил работу и готов идти обратно");
    }
}