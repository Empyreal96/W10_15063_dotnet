// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFocusCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameFocusCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2066074968, 448, 16485, 156, 64, 193, 167, 33, 66, 92, 26)]
  internal interface IFrameFocusCapabilities
  {
    bool Supported { get; }

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }
  }
}
