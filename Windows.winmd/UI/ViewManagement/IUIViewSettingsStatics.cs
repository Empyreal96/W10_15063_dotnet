// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUIViewSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UIViewSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1499240357, 63734, 16847, 176, 251, 170, 205, 184, 31, 213, 246)]
  internal interface IUIViewSettingsStatics
  {
    UIViewSettings GetForCurrentView();
  }
}
