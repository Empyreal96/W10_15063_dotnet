﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Notification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class Notification : INotification
  {
    [MethodImpl]
    public extern Notification();

    public extern IReference<DateTime> ExpirationTime { [MethodImpl] get; [MethodImpl] set; }

    public extern NotificationVisual Visual { [MethodImpl] get; [MethodImpl] set; }
  }
}
