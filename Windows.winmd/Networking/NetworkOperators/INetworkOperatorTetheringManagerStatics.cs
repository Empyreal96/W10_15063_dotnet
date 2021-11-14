// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1052555980, 63683, 16476, 153, 100, 112, 161, 238, 171, 225, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  internal interface INetworkOperatorTetheringManagerStatics
  {
    TetheringCapability GetTetheringCapability(string networkAccountId);

    NetworkOperatorTetheringManager CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
