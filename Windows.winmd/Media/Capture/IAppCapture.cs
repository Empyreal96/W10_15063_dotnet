// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAppCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2538198099, 41626, 17901, 143, 41, 34, 208, 153, 66, 207, 247)]
  [ExclusiveTo(typeof (AppCapture))]
  internal interface IAppCapture
  {
    bool IsCapturingAudio { get; }

    bool IsCapturingVideo { get; }

    event TypedEventHandler<AppCapture, object> CapturingChanged;
  }
}
