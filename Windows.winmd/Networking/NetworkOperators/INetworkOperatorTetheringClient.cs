// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringClient))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1889346892, 22879, 18503, 187, 48, 100, 105, 53, 84, 41, 24)]
  internal interface INetworkOperatorTetheringClient
  {
    string MacAddress { get; }

    IVectorView<HostName> HostNames { get; }
  }
}
