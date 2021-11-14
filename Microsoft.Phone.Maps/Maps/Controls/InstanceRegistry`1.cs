// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.InstanceRegistry`1
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Maps.Controls
{
  internal class InstanceRegistry<T>
  {
    private readonly object lockObject = new object();
    private Dictionary<int, WeakReference> registryTable = new Dictionary<int, WeakReference>();

    public void Insert(int instanceId, T instance)
    {
      lock (this.lockObject)
        this.registryTable[instanceId] = new WeakReference((object) instance);
    }

    public void Remove(int instanceId)
    {
      lock (this.lockObject)
        this.registryTable.Remove(instanceId);
    }

    public T FindInstance(int instanceId)
    {
      lock (this.lockObject)
      {
        WeakReference weakReference;
        if (this.registryTable.TryGetValue(instanceId, out weakReference))
          return (T) weakReference.Target;
      }
      return default (T);
    }
  }
}
