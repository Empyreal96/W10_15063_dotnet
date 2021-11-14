// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.PropertyDescriptor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Workaround
{
  public abstract class PropertyDescriptor : MemberDescriptor
  {
    private Hashtable valueChangedHandlers;

    protected PropertyDescriptor(string name, Attribute[] attrs)
      : base(name, attrs)
    {
    }

    protected PropertyDescriptor(MemberDescriptor descr)
      : base(descr)
    {
    }

    protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
      : base(descr, attrs)
    {
    }

    public abstract Type ComponentType { get; }

    public abstract bool IsReadOnly { get; }

    public abstract Type PropertyType { get; }

    public virtual void AddValueChanged(object component, EventHandler handler)
    {
      if (component == null)
        throw new ArgumentNullException(nameof (component));
      if (handler == null)
        throw new ArgumentNullException(nameof (handler));
      if (this.valueChangedHandlers == null)
        this.valueChangedHandlers = new Hashtable();
      EventHandler valueChangedHandler = (EventHandler) this.valueChangedHandlers[component];
      this.valueChangedHandlers[component] = (object) Delegate.Combine((Delegate) valueChangedHandler, (Delegate) handler);
    }

    public abstract bool CanResetValue(object component);

    public abstract object GetValue(object component);

    protected virtual void OnValueChanged(object component, EventArgs e)
    {
      if (component == null || this.valueChangedHandlers == null)
        return;
      EventHandler valueChangedHandler = (EventHandler) this.valueChangedHandlers[component];
      if (valueChangedHandler == null)
        return;
      valueChangedHandler(component, e);
    }

    public virtual void RemoveValueChanged(object component, EventHandler handler)
    {
      if (component == null)
        throw new ArgumentNullException(nameof (component));
      if (handler == null)
        throw new ArgumentNullException(nameof (handler));
      if (this.valueChangedHandlers == null)
        return;
      EventHandler eventHandler = (EventHandler) Delegate.Remove((Delegate) this.valueChangedHandlers[component], (Delegate) handler);
      if (eventHandler != null)
        this.valueChangedHandlers[component] = (object) eventHandler;
      else
        this.valueChangedHandlers.Remove(component);
    }

    protected internal EventHandler GetValueChangedHandler(object component) => component != null && this.valueChangedHandlers != null ? (EventHandler) this.valueChangedHandlers[component] : (EventHandler) null;

    public abstract void ResetValue(object component);

    public abstract void SetValue(object component, object value);

    public abstract bool ShouldSerializeValue(object component);

    public virtual bool SupportsChangeEvents => false;
  }
}
