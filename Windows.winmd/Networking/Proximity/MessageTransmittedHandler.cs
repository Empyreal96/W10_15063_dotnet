﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.MessageTransmittedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020898634, 63202, 19837, 133, 108, 120, 252, 142, 252, 2, 30)]
  public delegate void MessageTransmittedHandler(ProximityDevice sender, long messageId);
}
