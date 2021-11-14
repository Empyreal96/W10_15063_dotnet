// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.FileUpdateRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileUpdateRequest : IFileUpdateRequest, IFileUpdateRequest2
  {
    public extern string ContentId { [MethodImpl] get; }

    public extern StorageFile File { [MethodImpl] get; }

    public extern FileUpdateStatus Status { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern FileUpdateRequestDeferral GetDeferral();

    [MethodImpl]
    public extern void UpdateLocalFile(IStorageFile value);

    public extern string UserInputNeededMessage { [MethodImpl] get; [MethodImpl] set; }
  }
}
