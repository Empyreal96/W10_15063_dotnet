// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICaptureElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(832946407, 62215, 19786, 182, 38, 233, 120, 134, 63, 91, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CaptureElement))]
  [WebHostHidden]
  internal interface ICaptureElement
  {
    MediaCapture Source { get; set; }

    Stretch Stretch { get; set; }
  }
}
