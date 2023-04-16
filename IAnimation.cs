using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimation
{
    void Update(float value);
    void Begin();
    void Complete();
    void OnPaused();
    void OnResumed();
    void OnCanceled();
}

