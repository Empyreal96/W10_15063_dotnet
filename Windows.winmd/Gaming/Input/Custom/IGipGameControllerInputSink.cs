// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipGameControllerInputSink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(2718993087, 2545, 17340, 161, 64, 128, 248, 153, 236, 54, 251)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IGipGameControllerInputSink : IGameControllerInputSink
  {
    void OnKeyReceived(ulong timestamp, byte keyCode, bool isPressed);

    void OnMessageReceived(
      ulong timestamp,
      GipMessageClass messageClass,
      byte messageId,
      byte sequenceId,
      byte[] messageBuffer);
  }
}
