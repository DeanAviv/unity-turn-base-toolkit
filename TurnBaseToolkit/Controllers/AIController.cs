using UnityEngine;

namespace TurnBaseToolkit
{
    public class AIController : MonoBehaviour, IPlayTurn
    {
        private ITurnManager _turnManager;
        public void Initialize(ITurnManager manager)
        {
            _turnManager = manager;
        }

        public void BeginTurn()
        {
            // Placeholder for AI turn initialization
        }

        public void EndTurn()
        {
            // Placeholder for AI turn ending
            _turnManager.EndTurn();
        }
    }
}