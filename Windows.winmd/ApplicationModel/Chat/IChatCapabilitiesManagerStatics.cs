// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatCapabilitiesManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatCapabilitiesManager))]
  [Guid(3044683568, 28737, 17806, 176, 207, 124, 13, 159, 234, 51, 58)]
  internal interface IChatCapabilitiesManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<ChatCapabilities> GetCachedCapabilitiesAsync(
      string address);

    [RemoteAsync]
    IAsyncOperation<ChatCapabilities> GetCapabilitiesFromNetworkAsync(
      string address);
  }
}
