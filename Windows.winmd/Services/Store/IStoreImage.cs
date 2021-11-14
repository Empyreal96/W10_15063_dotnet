// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StoreImage))]
  [Guid(136303176, 44468, 19300, 169, 147, 120, 71, 137, 146, 110, 213)]
  [ContractVersion(typeof (StoreContract), 65536)]
  internal interface IStoreImage
  {
    Uri Uri { get; }

    string ImagePurposeTag { get; }

    uint Width { get; }

    uint Height { get; }

    string Caption { get; }
  }
}
