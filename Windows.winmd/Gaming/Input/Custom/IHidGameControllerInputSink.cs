// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IHidGameControllerInputSink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(4149527330, 6189, 16612, 161, 38, 252, 238, 79, 250, 30, 49)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public interface IHidGameControllerInputSink : IGameControllerInputSink
  {
    void OnInputReportReceived(ulong timestamp, byte reportId, byte[] reportBuffer);
  }
}
