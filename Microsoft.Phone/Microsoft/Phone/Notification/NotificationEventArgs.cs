﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Notification.NotificationEventArgs
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Phone.Notification
{
  [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Args is correct")]
  public class NotificationEventArgs : EventArgs
  {
    private IDictionary<string, string> collection;

    internal NotificationEventArgs(IDictionary<string, string> collection) => this.collection = collection;

    public IDictionary<string, string> Collection => this.collection;
  }
}
