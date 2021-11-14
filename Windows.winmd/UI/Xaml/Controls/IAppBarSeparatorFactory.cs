// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarSeparatorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(98182605, 62471, 18654, 139, 80, 255, 135, 209, 226, 129, 143)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarSeparator))]
  internal interface IAppBarSeparatorFactory
  {
    AppBarSeparator CreateInstance(object outer, out object inner);
  }
}
