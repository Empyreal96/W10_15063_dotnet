// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ActivationViewSwitcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ActivationViewSwitcher : IActivationViewSwitcher
  {
    [RemoteAsync]
    [Overload("ShowAsStandaloneAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAsStandaloneAsync(int viewId);

    [Overload("ShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    [MethodImpl]
    public extern bool IsViewPresentedOnActivationVirtualDesktop(int viewId);
  }
}
