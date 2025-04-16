# Unity Turn-Based Toolkit

A modular and extensible framework for building turn-based games in Unity, featuring a clean state-driven architecture, intuitive input handling, and built-in support for Dependency Injection via Zenject.

---

## ✨ Features

- 🔁 Turn-based round controller
- 🧠 AI and player turn state system
- 💡 State-driven design using abstract classes/interfaces
- 🧩 Plug-and-play architecture with Zenject support
- 🎯 Great for tactical RPGs, board games, or mini-games

---

## 📦 Installation

1. Clone or download the repository
2. Import the scripts into your Unity project
3. Set up the game objects and turn manager prefab
4. (Optional) Add a Zenject `SceneContext` and bind your dependencies

---

## 🛠️ Usage Example

Create a custom player state:

```csharp
public class PlayerTurnState : TurnState
{
    public override void Enter()
    {
        Debug.Log("Player's Turn Begins!");
        // Handle player input here
    }

    public override void Exit()
    {
        Debug.Log("Player's Turn Ends.");
    }
}
```

Use the turn manager to transition:

```csharp
_turnManager.SetState(new PlayerTurnState());
```

---

## 📁 Structure Overview

```
TurnBaseToolkit/
├── TurnManager.cs
├── TurnState.cs
├── PlayerTurnState.cs
├── EnemyTurnState.cs
├── TurnContext.cs
└── Installer.cs (for Zenject)
```

---

## 🧩 Zenject Integration

If you're using [Zenject](https://github.com/modesttree/Zenject):

```csharp
public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<TurnManager>().AsSingle();
        Container.Bind<ITurnState>().To<PlayerTurnState>().AsTransient();
    }
}
```

---

## 🔍 Use Cases

- Tactical RPGs (e.g., Fire Emblem style)
- Board games and chess-like logic
- Puzzle games with enemy phases

---

## 📸 Screenshots / GIFs

_Coming soon!_

---

## 📄 License

MIT © [Dean Aviv](https://github.com/DeanAviv)
