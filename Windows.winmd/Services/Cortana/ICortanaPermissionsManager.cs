// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaPermissionsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [ExclusiveTo(typeof (CortanaPermissionsManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(420688096, 34453, 17290, 149, 69, 61, 164, 232, 34, 221, 180)]
  internal interface ICortanaPermissionsManager
  {
    bool IsSupported();

    [RemoteAsync]
    IAsyncOperation<bool> ArePermissionsGrantedAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    IAsyncOperation<CortanaPermissionsChangeResult> GrantPermissionsAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    IAsyncOperation<CortanaPermissionsChangeResult> RevokePermissionsAsync(
      IIterable<CortanaPermission> permissions);
  }
}
