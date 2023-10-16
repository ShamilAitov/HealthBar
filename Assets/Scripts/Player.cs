using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    public event UnityAction HealthUpdate;
    private float _maxHealth;
    private float _minHealth = 0;

    public float Health => _health;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void Damage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);
        HealthUpdate?.Invoke();
    }

    public void Heal(float health)
    {
        _health = Mathf.Clamp(_health + health, _minHealth, _maxHealth);
        HealthUpdate?.Invoke();
    }
}
