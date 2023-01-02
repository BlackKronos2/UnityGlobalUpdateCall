using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoCacheGlobalTick : MonoBehaviour
{
    private void Update()
    {
        for (int i = 0; i < MonoCache.allUpdates.Count; i++)
            MonoCache.allUpdates[i].UpdateTick();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < MonoCache.allFixedUpdates.Count; i++)
            MonoCache.allFixedUpdates[i].FixedUpdateTick();
    }
}
