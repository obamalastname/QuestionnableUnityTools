using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extension for IAnimation and MonoBehavior to run animations
/// </summary>
public static class AnimationExtensions
{
    /// <summary>
    /// Run an animation using MonoBehavior since it needs a Coroutine to run
    /// </summary>
    /// <param name="iAnimation">The animation</param>
    /// <param name="runner">The Monobehavior that will use a coroutine to run the animation</param>
    /// <param name="time">The time of the animation</param>
    /// <returns>Returns an AnimationQueue, so we can add more animation to it</returns>
    public static AnimationQueue Run(this IAnimation iAnimation, MonoBehaviour runner, float time)
    {
        return AnimationQueue.Animate(iAnimation, runner, time);
    }
    
    public static AnimationQueue Run(this MonoBehaviour runner, IAnimation iAnimation, float time)
    {
        return Run(iAnimation, runner, time);
    }
    

}
