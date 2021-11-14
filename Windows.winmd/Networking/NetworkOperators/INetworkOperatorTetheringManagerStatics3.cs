// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2413473206, 19193, 20257, 155, 88, 213, 62, 159, 36, 35, 30)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  internal interface INetworkOperatorTetheringManagerStatics3
  {
    [Overload("CreateFromConnectionProfileWithTargetAdapter")]
    NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile,
      NetworkAdapter adapter);
  }
}
