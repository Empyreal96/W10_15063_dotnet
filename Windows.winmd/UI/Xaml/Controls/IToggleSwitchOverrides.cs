// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSwitchOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3218112339, 63690, 20039, 148, 158, 158, 128, 66, 155, 61, 22)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleSwitch))]
  internal interface IToggleSwitchOverrides
  {
    void OnToggled();

    void OnOnContentChanged(object oldContent, object newContent);

    void OnOffContentChanged(object oldContent, object newContent);

    void OnHeaderChanged(object oldContent, object newContent);
  }
}
