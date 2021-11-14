// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameController2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(13876341, 55420, 18523, 138, 9, 92, 53, 133, 104, 180, 39)]
  internal interface IFrameController2
  {
    FrameFlashControl FlashControl { get; }
  }
}
