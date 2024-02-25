# Turn-Based Toolkit

This project demonstrates a turn-based game system implemented in Unity using C# scripting. It includes various components such as GameManager, PlayerController, AIController, and EndTurnButton to manage the game flow and player interactions.

## Project Structure

### CompositionRoot.cs

The `CompositionRoot` class serves as the entry point where dependencies are initialized and wired together. It initializes instances of GameManager, EndTurnButton, PlayerController, and AIController and ensures they are properly connected.

### Logic Interfaces

- `IPlayTurn`: Defines interfaces for player and AI controllers to begin and end their turns.
- `ITurnManager`: Defines an interface for the GameManager to initialize turns and handle the end of each turn.

### Game States

The `GameState` enum defines various states of the game, including InitGame, PlayerTurn, AiTurn, and Results.

### GameManager.cs

The GameManager class implements the game logic, including initializing turns, handling player and AI turns, and managing game states.

### Controllers

- `PlayerController`: Represents the player controller, implementing the IPlayTurn interface to handle player turn logic.
- `AIController`: Represents the AI controller, implementing the IPlayTurn interface to handle AI turn logic.

## Usage

To use this project, follow these steps:

1. Attach the CompositionRoot script to a GameObject in your Unity scene.
2. Assign references to GameManager, EndTurnButton, PlayerController, and AIController in the Inspector.
3. Run the game and observe the turn-based gameplay mechanics.

## Dependencies

This project has no external dependencies beyond Unity itself.

## License

This project is licensed under the [MIT License](LICENSE).
