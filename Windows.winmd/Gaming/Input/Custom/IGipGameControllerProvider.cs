// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Gaming.Input.Custom
{
  [Guid(3687783961, 6901, 17832, 191, 2, 160, 238, 80, 200, 35, 252)]
  [ExclusiveTo(typeof (GipGameControllerProvider))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IGipGameControllerProvider : IGameControllerProvider
  {
    void SendMessage(GipMessageClass messageClass, byte messageId, byte[] messageBuffer);

    void SendReceiveMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] requestMessageBuffer,
      [Out] byte[] responseMessageBuffer);

    [RemoteAsync]
    IAsyncOperationWithProgress<GipFirmwareUpdateResult, GipFirmwareUpdateProgress> UpdateFirmwareAsync(
      IInputStream firmwareImage);
  }
}
