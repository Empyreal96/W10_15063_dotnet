// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaPermissionsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [Static(typeof (ICortanaPermissionsManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CortanaPermissionsManager : ICortanaPermissionsManager
  {
    [MethodImpl]
    public extern bool IsSupported();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ArePermissionsGrantedAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CortanaPermissionsChangeResult> GrantPermissionsAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CortanaPermissionsChangeResult> RevokePermissionsAsync(
      IIterable<CortanaPermission> permissions);

    [MethodImpl]
    public static extern CortanaPermissionsManager GetDefault();
  }
}
