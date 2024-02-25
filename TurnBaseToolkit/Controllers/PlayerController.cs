using UnityEngine;

namespace TurnBaseToolkit
{
    public class PlayerController : MonoBehaviour, IPlayTurn
    {
        private ITurnManager _turnManager;
        public void Initialize(ITurnManager manager)
        {
            _turnManager = manager;
        }

        public void BeginTurn()
        {
            // Placeholder for player turn initialization
        }

        public void EndTurn()
        {
            // Placeholder for player turn ending
            _turnManager.EndTurn();
        }
    }
}