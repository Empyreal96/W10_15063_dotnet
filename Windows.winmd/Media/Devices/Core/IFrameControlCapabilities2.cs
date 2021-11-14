// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameControlCapabilities2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(3466265700, 18224, 17423, 189, 62, 239, 232, 168, 242, 48, 168)]
  [ExclusiveTo(typeof (FrameControlCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameControlCapabilities2
  {
    FrameFlashCapabilities Flash { get; }
  }
}
