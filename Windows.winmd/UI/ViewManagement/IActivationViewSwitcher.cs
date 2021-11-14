// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IActivationViewSwitcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(3701939126, 29520, 18731, 170, 199, 200, 161, 61, 114, 36, 173)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivationViewSwitcher))]
  internal interface IActivationViewSwitcher
  {
    [RemoteAsync]
    [Overload("ShowAsStandaloneAsync")]
    IAsyncAction ShowAsStandaloneAsync(int viewId);

    [Overload("ShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    IAsyncAction ShowAsStandaloneAsync(int viewId, ViewSizePreference sizePreference);

    bool IsViewPresentedOnActivationVirtualDesktop(int viewId);
  }
}
