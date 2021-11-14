// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStorePackageUpdate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StorePackageUpdate))]
  [Guid(336568656, 15551, 18997, 185, 31, 72, 39, 28, 49, 176, 114)]
  [ContractVersion(typeof (StoreContract), 65536)]
  internal interface IStorePackageUpdate
  {
    Package Package { get; }

    bool Mandatory { get; }
  }
}
