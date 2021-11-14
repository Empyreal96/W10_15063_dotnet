// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IContentPrefetcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2832660308, 32193, 19673, 136, 16, 42, 106, 169, 65, 126, 17)]
  [ExclusiveTo(typeof (ContentPrefetcher))]
  internal interface IContentPrefetcher
  {
    IVector<Uri> ContentUris { get; }

    Uri IndirectContentUri { set; get; }
  }
}
