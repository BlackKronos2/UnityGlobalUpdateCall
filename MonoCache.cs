using System.Collections.Generic;
using UnityEngine;

public class MonoCache : MonoBehaviour
{
    public static List<MonoCache> allUpdates = new List<MonoCache>(1001);

    private void OnEnable() => allUpdates.Add(this);
    private void OnDisable() => allUpdates.Remove(this);
    private void OnDestroy() => allUpdates.Remove(this);

    public static List<MonoCache> allFixedUpdates = new List<MonoCache>(1001);

    protected void AddOnFixedUpdates() => allFixedUpdates.Add(this);
    protected void RemoveFromFixedUpdates() => allFixedUpdates.Remove(this);

    public void UpdateTick() => OnTick();

    public void FixedUpdateTick() => OnFixedTick();

    public virtual void OnTick() { }

    public virtual void OnFixedTick() { }

}
