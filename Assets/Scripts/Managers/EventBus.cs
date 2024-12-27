using System;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    public static event Action <int> OnEnemyDied;

    public static void EnemyDied(int value)
    {
        OnEnemyDied?.Invoke(value);
    }
}
