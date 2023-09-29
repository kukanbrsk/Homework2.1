using UnityEngine;

public class ChillState : IState
{
    private readonly IStateSwitcher _stateSwitcher;
    private readonly StateMachineData _data;
    private readonly Character _character;

    public ChillState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
    {
        _stateSwitcher = stateSwitcher;
        _data = data;
        _character = character;
    }

    public void Enter()
    {
        Debug.Log("NPC начал отдыхать");
    }

    public void Update()
    {
        _character.CharacterStateMachine.SwitchState<WalkState>();
    }

    public void Exit()
    {
        Debug.Log("NPC закончил отдых и готов начать заново");
    }
}