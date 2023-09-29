using UnityEngine;

public class Character : MonoBehaviour
{
   [SerializeField] private Transform target;
   [SerializeField] private float speed = 5f;
   
   private CharacterStateMachine _stateMachine;
   
   public Transform Target => target;
   public float Speed => speed;
   public CharacterStateMachine CharacterStateMachine => _stateMachine;

   private void Awake()
   {
      _stateMachine = new CharacterStateMachine(this);
   }
   
   private void Update()
   {
      _stateMachine.UpdateState();
   }
}