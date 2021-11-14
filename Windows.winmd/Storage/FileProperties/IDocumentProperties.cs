// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IDocumentProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (DocumentProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2125142460, 6177, 18723, 180, 169, 10, 234, 64, 77, 0, 112)]
  internal interface IDocumentProperties : IStorageItemExtraProperties
  {
    IVector<string> Author { get; }

    string Title { get; set; }

    IVector<string> Keywords { get; }

    string Comment { get; set; }
  }
}
