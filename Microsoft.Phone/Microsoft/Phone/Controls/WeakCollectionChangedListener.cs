// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WeakCollectionChangedListener
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Specialized;

namespace Microsoft.Phone.Controls
{
  internal class WeakCollectionChangedListener
  {
    private WeakReference<NotifyCollectionChangedEventHandler> _handler;
    private INotifyCollectionChanged _source;

    private WeakCollectionChangedListener(
      INotifyCollectionChanged source,
      NotifyCollectionChangedEventHandler handler)
    {
      this._source = source;
      // ISSUE: method pointer
      this._source.CollectionChanged += new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnSourceCollectionChanged));
      this._handler = new WeakReference<NotifyCollectionChangedEventHandler>(handler);
    }

    public static WeakCollectionChangedListenerToken CreateIfNecessary(
      object source,
      NotifyCollectionChangedEventHandler handler)
    {
      return source is INotifyCollectionChanged ? new WeakCollectionChangedListenerToken(new WeakCollectionChangedListener(source as INotifyCollectionChanged, handler), handler) : (WeakCollectionChangedListenerToken) null;
    }

    public void Disconnect()
    {
      if (this._source == null)
        return;
      // ISSUE: method pointer
      this._source.CollectionChanged -= new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnSourceCollectionChanged));
      this._source = (INotifyCollectionChanged) null;
      this._handler = (WeakReference<NotifyCollectionChangedEventHandler>) null;
    }

    private void OnSourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      if (this._handler == null)
        return;
      NotifyCollectionChangedEventHandler changedEventHandler;
      if (this._handler.TryGetTarget(ref changedEventHandler))
        changedEventHandler.Invoke(sender, e);
      else
        this.Disconnect();
    }
  }
}
