// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITileBrushFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2853543804, 60778, 20403, 176, 20, 181, 199, 227, 121, 164, 222)]
  [ExclusiveTo(typeof (TileBrush))]
  [WebHostHidden]
  internal interface ITileBrushFactory
  {
    TileBrush CreateInstance(object outer, out object inner);
  }
}
