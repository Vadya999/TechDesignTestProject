using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private HitDetection _hitDetection;
    [SerializeField] private Animator _animatorAvacato;
    [SerializeField] private Animator _animatorApple;

    private const string IsRotate = "is_rotate";

    private void Start()
    {
        _hitDetection.hitAction += StartAnimation;
    }

    private void StartAnimation()
    {
        _animatorApple.SetBool(IsRotate, true);
        _animatorAvacato.SetBool(IsRotate, true);
    }

    private void OnDestroy()
    {
        _hitDetection.hitAction -= StartAnimation;
    }
}
