// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyoutFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SettingsFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1208774673, 22442, 19894, 182, 253, 236, 103, 111, 109, 65, 78)]
  internal interface ISettingsFlyoutFactory
  {
    SettingsFlyout CreateInstance(object outer, out object inner);
  }
}
