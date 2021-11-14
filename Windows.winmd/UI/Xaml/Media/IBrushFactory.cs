// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrushFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Brush))]
  [Guid(966154402, 5371, 19343, 131, 230, 110, 61, 171, 18, 6, 155)]
  [WebHostHidden]
  internal interface IBrushFactory
  {
    Brush CreateInstance(object outer, out object inner);
  }
}
