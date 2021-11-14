// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(781272120, 64851, 19341, 133, 139, 54, 68, 38, 159, 142, 77)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarToggleButton
  {
    string Label { get; set; }

    IconElement Icon { get; set; }
  }
}
