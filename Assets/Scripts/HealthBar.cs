using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;


[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _sliderChangeTime = 1;

    private void OnDisable()
    {
        _player.HealthUpdate -= UpdateHealthValues;
    }

    private void OnEnable()
    {
        _player.HealthUpdate += UpdateHealthValues;
    }

    public void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _player.Health;
        _slider.value = _slider.maxValue;
    }

    private void UpdateHealthValues()
    {
       _slider.DOValue(_player.Health, _sliderChangeTime);
    }
}
