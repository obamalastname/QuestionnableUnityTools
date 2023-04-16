using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private PositionAnimation PositionAnimation;
    private void Start()
    {
        PositionAnimation.Run(this, 2f);
    }
}
