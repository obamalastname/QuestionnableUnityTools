using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationList
{

}

public struct PositionAnimation : IAnimation
{ 
     public Transform TransformToAnimate;
     public Vector3 StartPosition;
     public Vector3 EndPosition;
     public void Update(float percentDone) 
     {
         Debug.Log("ok " + percentDone);
         TransformToAnimate.position = Vector3.Lerp(StartPosition, EndPosition, percentDone);
     }

     public void Begin()
     {
         
     }
     public void Complete()
     {
         
     }

     public void OnPaused()
     {
        
     }

     public void OnResumed()
     {
        
     }
     public void OnCanceled()
     {
         
     }
}
