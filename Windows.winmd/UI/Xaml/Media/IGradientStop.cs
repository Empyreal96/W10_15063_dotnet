// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientStop
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(1717519614, 11865, 19530, 171, 83, 7, 106, 16, 12, 205, 129)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GradientStop))]
  internal interface IGradientStop
  {
    Color Color { get; set; }

    double Offset { get; set; }
  }
}
