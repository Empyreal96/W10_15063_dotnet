// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.WeakEventListener`1
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;

namespace Microsoft.Phone.Shell.Interop
{
  internal class WeakEventListener<T> where T : class
  {
    private readonly WeakReference _weakInstance;

    public Action<T> OnEventAction { get; set; }

    public Action<WeakEventListener<T>> OnDetachAction { get; set; }

    public WeakEventListener(T instance) => this._weakInstance = (object) instance != null ? new WeakReference((object) instance) : throw new ArgumentNullException(nameof (instance));

    public void OnEvent()
    {
      T target = (T) this._weakInstance.Target;
      if ((object) target != null)
      {
        if (this.OnEventAction == null)
          return;
        this.OnEventAction(target);
      }
      else
        this.Detach();
    }

    public void Detach()
    {
      if (this.OnDetachAction == null)
        return;
      this.OnDetachAction(this);
      this.OnDetachAction = (Action<WeakEventListener<T>>) null;
    }
  }
}
