// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfileFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(541883592, 48429, 20109, 164, 179, 69, 94, 195, 55, 56, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionProfileFilter))]
  internal interface IConnectionProfileFilter
  {
    bool IsConnected { set; get; }

    bool IsWwanConnectionProfile { set; get; }

    bool IsWlanConnectionProfile { set; get; }

    NetworkCostType NetworkCostType { set; get; }

    IReference<Guid> ServiceProviderGuid { set; get; }
  }
}
