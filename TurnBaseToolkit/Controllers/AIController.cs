using UnityEngine;

namespace TurnBaseToolkit
{
    public class AIController : MonoBehaviour, IPlayTurn
    {
        private IControllerState _currentState;

        private ITurnManager _turnManager;
        public void Initialize(ITurnManager manager)
        {
            _turnManager = manager;
            SetState(new BalancedState());
        }

        private void SetState(IControllerState state) => _currentState = state;

        public void BeginTurn()
        {
            // Placeholder for AI turn behaviour using the state pattern 
            _currentState.PerformStateAction();
        }

        public void EndTurn()
        {
            // Placeholder for AI turn ending
            _turnManager.EndTurn();
        }
    }
}