using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _damage = 10;
    private float _health = 10;

    public void Start()
    {
        _slider.maxValue = _player.Health;
        _slider.value = _player.Health;
    }

    public void IncreasedHealth()
    {
        _player.IncreasedHealth(_health);
        _slider.value = _player.Health;
    }

    public void ReducedHealth()
    {
        _player.ReducedHealth(_damage);
        _slider.value = _player.Health;
    }
}
