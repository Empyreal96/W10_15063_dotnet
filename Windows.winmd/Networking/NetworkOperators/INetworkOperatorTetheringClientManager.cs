// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringClientManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [Guid(2444312598, 36298, 16933, 187, 237, 238, 248, 184, 215, 24, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkOperatorTetheringClientManager
  {
    IVectorView<NetworkOperatorTetheringClient> GetTetheringClients();
  }
}
