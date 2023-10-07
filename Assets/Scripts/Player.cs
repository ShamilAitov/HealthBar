using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _maxHealth;
    private float _minHealth = 0;

    public float Health => _health;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void ReducedHealth(float damage)
    {
        if (_health > _minHealth) 
        {
            _health -= damage;
        }
    }

    public void IncreasedHealth(float health)
    {
        if (_health < _maxHealth)
        {
            _health += health;
        }
        
    }
}
