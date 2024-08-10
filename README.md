# Unity Events, Delegate and Lambda Expressions

This project demonstrates the use of events, delegates, and lambda expressions in Unity. The project features a simple scoring system where the player's score increases whenever the left mouse button is clicked.

## Project Overview

### EventManager
The `EventManager` class is responsible for detecting mouse clicks and invoking an event that other components can subscribe to. This class demonstrates how to create and use delegates and events in Unity.

```csharp
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void MouseClickDelegate();

    public static event MouseClickDelegate OnMouseClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseClick?.Invoke();
        }
    }
}
```

### ScoreManager
The `ScoreManager` class handles the player's score and updates the UI using TextMeshPro. It subscribes to the `OnMouseClick` event using a lambda expression to increase the score each time the event is triggered.

```csharp
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreManager
{
    private int _score;
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        EventManager.OnMouseClick += () => IncreaseScore();
    }

    private void OnDisable()
    {
        EventManager.OnMouseClick -= () => IncreaseScore();
    }

    public void IncreaseScore()
    {
        _score++;
        scoreText.text = $"Score: {_score}";
    }
}
```

## Key Concepts

- **Events and Delegates**: The `EventManager` uses a delegate to define an event that other classes can subscribe to. This allows for decoupled communication between components.

- **Lambda Expressions**: The `ScoreManager` class uses a lambda expression to subscribe to the `OnMouseClick` event, demonstrating a concise way to define event handlers inline.

