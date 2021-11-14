﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledTileNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(180135637, 39388, 19576, 161, 28, 201, 231, 248, 109, 126, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScheduledTileNotification))]
  internal interface IScheduledTileNotification
  {
    XmlDocument Content { get; }

    DateTime DeliveryTime { get; }

    IReference<DateTime> ExpirationTime { set; get; }

    string Tag { set; get; }

    string Id { set; get; }
  }
}
