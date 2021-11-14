// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Image))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(116123538, 18370, 19858, 164, 136, 140, 214, 133, 208, 106, 202)]
  internal interface IImage3
  {
    CompositionBrush GetAlphaMask();
  }
}
