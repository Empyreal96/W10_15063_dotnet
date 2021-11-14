// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrushFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3980884426, 17853, 16689, 182, 37, 190, 134, 224, 124, 97, 18)]
  [ExclusiveTo(typeof (GradientBrush))]
  internal interface IGradientBrushFactory
  {
    GradientBrush CreateInstance(object outer, out object inner);
  }
}
