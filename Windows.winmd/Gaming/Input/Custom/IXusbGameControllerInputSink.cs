// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IXusbGameControllerInputSink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(2997624213, 28363, 17075, 138, 171, 2, 84, 1, 202, 71, 18)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public interface IXusbGameControllerInputSink : IGameControllerInputSink
  {
    void OnInputReceived(ulong timestamp, byte reportId, byte[] inputBuffer);
  }
}
