// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Static(typeof (ILicenseManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILicenseManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public static class LicenseManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RefreshLicensesAsync(
      LicenseRefreshOption refreshOption);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AddLicenseAsync(IBuffer license);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LicenseSatisfactionResult> GetSatisfactionInfosAsync(
      IIterable<string> contentIds,
      IIterable<string> keyIds);
  }
}
