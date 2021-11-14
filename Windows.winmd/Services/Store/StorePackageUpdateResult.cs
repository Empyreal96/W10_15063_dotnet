// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePackageUpdateResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorePackageUpdateResult : IStorePackageUpdateResult
  {
    public extern StorePackageUpdateState OverallState { [MethodImpl] get; }

    public extern IVectorView<StorePackageUpdateStatus> StorePackageUpdateStatuses { [MethodImpl] get; }
  }
}
