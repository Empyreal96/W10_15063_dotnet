// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.SafeRaise
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Controls
{
  internal static class SafeRaise
  {
    public static void Raise(EventHandler<EventArgs> eventToRaise, object sender) => SafeRaise.Raise<EventArgs>(eventToRaise, sender, EventArgs.Empty);

    public static void Raise<T>(EventHandler<T> eventToRaise, object sender, T args) where T : EventArgs
    {
      if (eventToRaise == null)
        return;
      eventToRaise(sender, args);
    }

    public static void Raise<T>(
      EventHandler<T> eventToRaise,
      object sender,
      SafeRaise.GetEventArgs<T> getEventArgs)
      where T : EventArgs
    {
      if (eventToRaise == null)
        return;
      eventToRaise(sender, getEventArgs());
    }

    public delegate T GetEventArgs<T>() where T : EventArgs;
  }
}
