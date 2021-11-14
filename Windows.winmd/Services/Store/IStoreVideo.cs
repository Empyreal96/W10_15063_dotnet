// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreVideo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(4067209604, 28510, 19906, 136, 108, 60, 99, 8, 60, 47, 148)]
  [ExclusiveTo(typeof (StoreVideo))]
  internal interface IStoreVideo
  {
    Uri Uri { get; }

    string VideoPurposeTag { get; }

    uint Width { get; }

    uint Height { get; }

    string Caption { get; }

    StoreImage PreviewImage { get; }
  }
}
