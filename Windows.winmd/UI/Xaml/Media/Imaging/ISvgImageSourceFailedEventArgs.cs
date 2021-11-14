// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSourceFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1757098352, 15564, 16437, 172, 1, 152, 52, 84, 61, 116, 78)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SvgImageSourceFailedEventArgs))]
  internal interface ISvgImageSourceFailedEventArgs
  {
    SvgImageSourceLoadStatus Status { get; }
  }
}
