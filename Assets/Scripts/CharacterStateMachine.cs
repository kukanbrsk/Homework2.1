using System.Collections.Generic;
using System.Linq;

public class CharacterStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;
    private static CharacterStateMachine _instance;
    
    public CharacterStateMachine(Character character)
    {
        var data = new StateMachineData();
        _states = new List<IState>()
        {
            new WalkState(this, data, character),
            new WorkState(this, data, character),
            new ChillState(this, data, character)
        };
        
        _currentState = _states[0];
        _currentState.Enter();
    }
   
    public void UpdateState() => _currentState?.Update();
    
    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);
        _currentState?.Exit();
        _currentState = state;
        _currentState?.Enter();
    }
}
