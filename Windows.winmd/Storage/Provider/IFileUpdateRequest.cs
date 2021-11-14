// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1086858550, 49662, 19859, 167, 146, 30, 115, 107, 199, 8, 55)]
  [ExclusiveTo(typeof (FileUpdateRequest))]
  internal interface IFileUpdateRequest
  {
    string ContentId { get; }

    StorageFile File { get; }

    FileUpdateStatus Status { get; set; }

    FileUpdateRequestDeferral GetDeferral();

    void UpdateLocalFile(IStorageFile value);
  }
}
