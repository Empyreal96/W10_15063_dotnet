// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIcon2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FontIcon))]
  [Guid(4142651469, 14312, 18158, 165, 116, 65, 173, 85, 4, 130, 224)]
  internal interface IFontIcon2
  {
    bool IsTextScaleFactorEnabled { get; set; }
  }
}
