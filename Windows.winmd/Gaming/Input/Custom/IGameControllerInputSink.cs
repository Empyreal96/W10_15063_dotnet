// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerInputSink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(536279330, 50752, 19576, 168, 32, 154, 113, 92, 85, 139, 203)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public interface IGameControllerInputSink
  {
    void OnInputResumed(ulong timestamp);

    void OnInputSuspended(ulong timestamp);
  }
}
