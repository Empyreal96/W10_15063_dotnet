﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PushNotificationChannel : IPushNotificationChannel
  {
    public extern string Uri { [MethodImpl] get; }

    public extern DateTime ExpirationTime { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;
  }
}
