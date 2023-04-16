using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationQueueExtension
{
	
	public static AnimationQueue Add(this AnimationQueue animationQueue, IAnimation iAnimation, float time)
	{
		return animationQueue.Add(iAnimation, time);
	}


}
