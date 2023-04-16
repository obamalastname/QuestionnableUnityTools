using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public readonly struct AnimationQueue
{
    private readonly List<IAnimation> animations;
    public readonly Queue<IEnumerator> coroutines;

    public AnimationQueue Add(IAnimation animation, float time)
    {
        animations.Add(animation);
        return default;

    }

    /// <summary>
    /// Play an Animation by creating an AnimationQueue
    /// </summary>
    /// <param name="iAnimation"></param>
    /// <param name="runner"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public static AnimationQueue Animate(IAnimation iAnimation, MonoBehaviour runner, float time)
    {
        AnimationQueue animationQueue = new AnimationQueue();
        animationQueue.coroutines.Enqueue(Play(iAnimation, time));
        runner.StartCoroutine(animationQueue.RunRoutine());
        return animationQueue;
    }

    public static IEnumerator Play(IAnimation iAnimation, float time)
    {
        float timer = 0;

        iAnimation.Begin();
        
        while (timer < time)
        {
            iAnimation.Update(timer);
            yield return new WaitForEndOfFrame();
            timer+=Time.deltaTime;
        }
        
        iAnimation.Complete();
    }
    
    public IEnumerator RunRoutine()
    {
        while (coroutines.Count > 0)
        {
            yield return coroutines.Dequeue();
        }
    }

    public void CompleteAll()
    {
        foreach (IAnimation animation in animations)
        {
            animation.Complete();
            //animations.Dequeue();
        }
    }

    public void CancelAll()
    {
        foreach (IAnimation animation in animations)
        {
            animation.OnCanceled();
            //animations.Dequeue();
        }
    }
}