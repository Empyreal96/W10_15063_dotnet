// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.MarshalByValueComponent
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.ComponentModel;

namespace Microsoft.Phone.Data.Workaround
{
  public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
  {
    private static readonly object EventDisposed = new object();
    private ISite site;
    private EventHandlerList events;

    ~MarshalByValueComponent() => this.Dispose(false);

    public event EventHandler Disposed
    {
      add => this.Events.AddHandler(MarshalByValueComponent.EventDisposed, (Delegate) value);
      remove => this.Events.RemoveHandler(MarshalByValueComponent.EventDisposed, (Delegate) value);
    }

    protected EventHandlerList Events
    {
      get
      {
        if (this.events == null)
          this.events = new EventHandlerList();
        return this.events;
      }
    }

    public virtual ISite Site
    {
      get => this.site;
      set => this.site = value;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      lock (this)
      {
        if (this.site != null && this.site.Container != null)
          this.site.Container.Remove((IComponent) this);
        if (this.events == null)
          return;
        EventHandler eventHandler = (EventHandler) this.events[MarshalByValueComponent.EventDisposed];
        if (eventHandler == null)
          return;
        eventHandler((object) this, EventArgs.Empty);
      }
    }

    public virtual IContainer Container => this.site?.Container;

    public virtual object GetService(Type service) => this.site != null ? this.site.GetService(service) : (object) null;

    public virtual bool DesignMode
    {
      get
      {
        ISite site = this.site;
        return site != null && site.DesignMode;
      }
    }

    public override string ToString()
    {
      ISite site = this.site;
      return site != null ? site.Name + " [" + this.GetType().FullName + "]" : this.GetType().FullName;
    }
  }
}
