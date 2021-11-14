// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.EventHandlerList
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Workaround
{
  public sealed class EventHandlerList : IDisposable
  {
    private EventHandlerList.ListEntry head;

    public Delegate this[object key]
    {
      get => this.Find(key)?.handler;
      set
      {
        EventHandlerList.ListEntry listEntry = this.Find(key);
        if (listEntry != null)
          listEntry.handler = value;
        else
          this.head = new EventHandlerList.ListEntry(key, value, this.head);
      }
    }

    public void AddHandler(object key, Delegate value)
    {
      EventHandlerList.ListEntry listEntry = this.Find(key);
      if (listEntry != null)
        listEntry.handler = Delegate.Combine(listEntry.handler, value);
      else
        this.head = new EventHandlerList.ListEntry(key, value, this.head);
    }

    public void AddHandlers(EventHandlerList listToAddFrom)
    {
      for (EventHandlerList.ListEntry listEntry = listToAddFrom.head; listEntry != null; listEntry = listEntry.next)
        this.AddHandler(listEntry.key, listEntry.handler);
    }

    public void Dispose() => this.head = (EventHandlerList.ListEntry) null;

    private EventHandlerList.ListEntry Find(object key)
    {
      EventHandlerList.ListEntry listEntry = this.head;
      while (listEntry != null && listEntry.key != key)
        listEntry = listEntry.next;
      return listEntry;
    }

    public void RemoveHandler(object key, Delegate value)
    {
      EventHandlerList.ListEntry listEntry = this.Find(key);
      if (listEntry == null)
        return;
      listEntry.handler = Delegate.Remove(listEntry.handler, value);
    }

    private sealed class ListEntry
    {
      internal EventHandlerList.ListEntry next;
      internal object key;
      internal Delegate handler;

      public ListEntry(object key, Delegate handler, EventHandlerList.ListEntry next)
      {
        this.next = next;
        this.key = key;
        this.handler = handler;
      }
    }
  }
}
