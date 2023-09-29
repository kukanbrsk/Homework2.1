using UnityEngine;

public class StateMachineData
{
    private Vector3 _target;
    private Vector3 _startPos;
    private float _speed;
    private bool _isWork;
    
    public Vector3 Target
    {
        get => _target;
        set => _target = value;
    }
    
    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }
}