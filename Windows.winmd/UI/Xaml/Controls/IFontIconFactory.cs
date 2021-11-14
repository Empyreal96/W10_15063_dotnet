// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(477633387, 14271, 19932, 161, 168, 27, 119, 219, 60, 240, 234)]
  [ExclusiveTo(typeof (FontIcon))]
  internal interface IFontIconFactory
  {
    FontIcon CreateInstance(object outer, out object inner);
  }
}
