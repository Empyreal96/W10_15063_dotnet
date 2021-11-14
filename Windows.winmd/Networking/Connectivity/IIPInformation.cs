// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IIPInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (IPInformation))]
  [Guid(3629204960, 5007, 18391, 155, 58, 54, 187, 72, 140, 239, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IIPInformation
  {
    NetworkAdapter NetworkAdapter { get; }

    IReference<byte> PrefixLength { get; }
  }
}
