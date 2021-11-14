// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [Guid(1529041938, 13808, 18919, 155, 8, 22, 210, 120, 251, 170, 66)]
  internal interface INetworkOperatorTetheringManagerStatics2
  {
    TetheringCapability GetTetheringCapabilityFromConnectionProfile(
      ConnectionProfile profile);

    [Overload("CreateFromConnectionProfile")]
    NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile);
  }
}
