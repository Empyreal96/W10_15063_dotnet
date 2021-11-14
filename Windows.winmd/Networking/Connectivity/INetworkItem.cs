// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (NetworkItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(29117753, 62944, 17767, 162, 140, 66, 8, 12, 131, 27, 43)]
  internal interface INetworkItem
  {
    Guid NetworkId { get; }

    NetworkTypes GetNetworkTypes();
  }
}
