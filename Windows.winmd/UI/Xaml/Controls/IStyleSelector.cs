// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStyleSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StyleSelector))]
  [Guid(3507568487, 55489, 19172, 152, 240, 216, 80, 69, 2, 240, 139)]
  internal interface IStyleSelector
  {
    Style SelectStyle(object item, DependencyObject container);
  }
}
