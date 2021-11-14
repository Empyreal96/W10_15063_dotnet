// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ILanIdentifierData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(2806940611, 54841, 17854, 163, 106, 196, 228, 174, 175, 109, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LanIdentifierData))]
  internal interface ILanIdentifierData
  {
    uint Type { get; }

    IVectorView<byte> Value { get; }
  }
}
