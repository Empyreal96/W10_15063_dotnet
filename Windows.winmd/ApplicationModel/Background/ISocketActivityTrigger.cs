// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISocketActivityTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SocketActivityTrigger))]
  [Guid(2847668240, 40414, 20362, 131, 227, 176, 224, 231, 165, 13, 112)]
  internal interface ISocketActivityTrigger
  {
    bool IsWakeFromLowPowerSupported { get; }
  }
}
