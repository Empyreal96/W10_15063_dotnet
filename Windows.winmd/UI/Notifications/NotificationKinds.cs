// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationKinds
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum NotificationKinds : uint
  {
    Unknown = 0,
    Toast = 1,
  }
}
