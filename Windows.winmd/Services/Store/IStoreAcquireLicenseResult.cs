// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreAcquireLicenseResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(4225209453, 61504, 19635, 154, 57, 41, 188, 236, 219, 226, 45)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreAcquireLicenseResult))]
  internal interface IStoreAcquireLicenseResult
  {
    StorePackageLicense StorePackageLicense { get; }

    HResult ExtendedError { get; }
  }
}
