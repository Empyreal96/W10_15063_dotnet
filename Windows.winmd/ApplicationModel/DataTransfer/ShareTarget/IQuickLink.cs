// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [Guid(1614693128, 61630, 19164, 172, 201, 139, 39, 171, 156, 245, 86)]
  [ExclusiveTo(typeof (QuickLink))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IQuickLink
  {
    string Title { get; set; }

    RandomAccessStreamReference Thumbnail { get; set; }

    string Id { get; set; }

    IVector<string> SupportedDataFormats { get; }

    IVector<string> SupportedFileTypes { get; }
  }
}
