using UnityEngine;

namespace TurnBaseToolkit
{
    public class GameManager : MonoBehaviour, ITurnManager
    {
        #region Fields
        private GameState _currentState;
        private IPlayTurn _playerController;
        private IPlayTurn _aiController;
        #endregion

        #region Public Methods
        /// <summary>
        /// Initializes the GameManager with player controller and AI controller.
        /// </summary>
        /// <param name="playerController">The player controller.</param>
        /// <param name="aiControllers">The AI controller.</param>
        public void Initialize(IPlayTurn playerController, IPlayTurn aiControllers)
        {
            _playerController = playerController;
            _aiController = aiControllers;
            InitTurns();
        }

        public void InitTurns()
        {
            SetCurrentState(GameState.InitGame);
        }

        /// <summary>
        /// Handles the end of the turn.
        /// </summary>
        public void EndTurn()
        {
            if (_currentState == GameState.PlayerTurn)
            {
                SetCurrentState(GameState.AiTurn);
            }
            else
            {
                SetCurrentState(GameState.PlayerTurn);
            }
        }
        #endregion

        #region Main Game Logic
        /// <summary>
        /// Sets the current state of the game.
        /// </summary>
        /// <param name="nextState">The next state of the game.</param>
        private void SetCurrentState(GameState nextState)
        {
            _currentState = nextState;
            // Handle state-specific behavior
            switch (_currentState)
            {
                case GameState.InitGame:
                    Debug.Log("Battle has begun!");
                    SetCurrentState(GameState.PlayerTurn);
                    break;
                case GameState.PlayerTurn:
                    _playerController.BeginTurn();
                    break;
                case GameState.AiTurn:
                    DoAITurn();
                    break;
                case GameState.Results:
                    ResultsState();
                    break;
            }
        }

        /// <summary>
        /// Executes AI turns sequentially.
        /// </summary>
        private void DoAITurn()
        {
            _aiController.BeginTurn();
        }
        #endregion

        #region Results Handling
        /// <summary>
        /// Handles the results state of the game.
        /// </summary>
        private void ResultsState()
        {
            // Determine and display results
            Debug.Log("Game Over");
        }
        #endregion
    }
}