using UnityEngine;
using UnityEngine.UI;

namespace TurnBaseToolkit
{
    public class EndTurnButton : MonoBehaviour
    {
        private Button _button;
        private ITurnManager _turnManager;

        public void Initialize(ITurnManager manager)
        {
            _turnManager = manager;
            _button = GetComponent<Button>();
            _button.onClick.AddListener(EndTurn);
        }

        private void EndTurn()
        {
            _turnManager.EndTurn();
        }
    }
}