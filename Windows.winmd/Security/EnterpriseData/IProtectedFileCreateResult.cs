// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IProtectedFileCreateResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Security.EnterpriseData
{
  [Guid(686026090, 59879, 18947, 159, 83, 189, 177, 97, 114, 105, 155)]
  [ExclusiveTo(typeof (ProtectedFileCreateResult))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  internal interface IProtectedFileCreateResult
  {
    StorageFile File { get; }

    IRandomAccessStream Stream { get; }

    FileProtectionInfo ProtectionInfo { get; }
  }
}
