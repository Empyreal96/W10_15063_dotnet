// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1146725457, 27112, 17420, 152, 150, 75, 180, 245, 246, 66, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarButton))]
  internal interface IAppBarButton
  {
    string Label { get; set; }

    IconElement Icon { get; set; }
  }
}
