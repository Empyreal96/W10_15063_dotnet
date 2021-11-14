// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Static(typeof (IPhotoImportManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public static class PhotoImportManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PhotoImportSource>> FindAllSourcesAsync();

    [MethodImpl]
    public static extern IVectorView<PhotoImportOperation> GetPendingOperations();
  }
}
