// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ILanIdentifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (LanIdentifier))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1219122090, 4360, 17734, 166, 203, 154, 116, 218, 75, 123, 160)]
  internal interface ILanIdentifier
  {
    LanIdentifierData InfrastructureId { get; }

    LanIdentifierData PortId { get; }

    Guid NetworkAdapterId { get; }
  }
}
