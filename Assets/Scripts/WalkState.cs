using UnityEngine;

public class WalkState : IState
{
    private readonly IStateSwitcher _stateSwitcher;
    private readonly StateMachineData _data;
    private readonly Character _character;

    public WalkState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
    {
        _stateSwitcher = stateSwitcher;
        _data = data;
        _character = character;
        data.Target = character.Target.position;
        data.Speed = character.Speed;
    }

    public void Enter()
    {
        Debug.Log("NPC начал идти к первой цели");
    }

    public void Update()
    {
        _character.transform.position =
            Vector3.MoveTowards(_character.transform.position, _data.Target, _data.Speed * Time.deltaTime);
        if (_character.transform.position == _data.Target)
        {
            _stateSwitcher.SwitchState<WorkState>();
        }
    }

    public void Exit()
    {
        Debug.Log("NPC достиг первой цели и готов начать работу");
    }
}