using UnityEngine;

namespace TurnBaseToolkit
{
    public class CompositionRoot : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private EndTurnButton _endTurnButton;
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private AIController _aiController;

        private void Awake()
        {
            _gameManager.Initialize(_playerController, _aiController);
            _endTurnButton.Initialize(_gameManager);
            _aiController.Initialize(_gameManager);
        }
    }
}