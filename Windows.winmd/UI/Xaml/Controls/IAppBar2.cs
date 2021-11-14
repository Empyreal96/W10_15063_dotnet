// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3282769843, 31447, 18038, 153, 16, 127, 227, 240, 232, 233, 147)]
  internal interface IAppBar2
  {
    AppBarClosedDisplayMode ClosedDisplayMode { get; set; }
  }
}
