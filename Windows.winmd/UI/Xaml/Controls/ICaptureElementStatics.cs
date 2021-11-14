// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICaptureElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(507743725, 32166, 16542, 128, 110, 48, 90, 228, 173, 155, 63)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CaptureElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICaptureElementStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
