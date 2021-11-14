// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1632045265, 36453, 17355, 146, 215, 142, 238, 23, 81, 95, 141)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarFactory
  {
    AppBar CreateInstance(object outer, out object inner);
  }
}
