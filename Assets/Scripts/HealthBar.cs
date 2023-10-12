using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _damage = 10;
    private float _health = 10;

    private void OnDisable()
    {
        _player.HealthUpdate -= UpdateHealthValues;
    }

    public void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _player.Health;
        UpdateHealthValues();
    }

    public void ImprovingHealth()
    {
        _player.ImprovingHealth(_health);
        _player.HealthUpdate += UpdateHealthValues;
    }

    public void DecreaseHealth()
    {
        _player.DecreaseHealth(_damage);
        _player.HealthUpdate += UpdateHealthValues;
    }

    private void UpdateHealthValues()
    {
        _slider.value = _player.Health;
    }
}
