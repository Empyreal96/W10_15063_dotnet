// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePackageLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorePackageLicense : IStorePackageLicense, IClosable
  {
    public extern event TypedEventHandler<StorePackageLicense, object> LicenseLost;

    public extern Package Package { [MethodImpl] get; }

    public extern bool IsValid { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReleaseLicense();

    [MethodImpl]
    public extern void Close();
  }
}
