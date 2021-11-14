// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.IDataProtectionProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.DataProtection
{
  [Guid(157522248, 60706, 17008, 189, 28, 109, 114, 192, 15, 135, 135)]
  [ExclusiveTo(typeof (DataProtectionProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataProtectionProvider
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> ProtectAsync(IBuffer data);

    [RemoteAsync]
    IAsyncOperation<IBuffer> UnprotectAsync(IBuffer data);

    [RemoteAsync]
    IAsyncAction ProtectStreamAsync(IInputStream src, IOutputStream dest);

    [RemoteAsync]
    IAsyncAction UnprotectStreamAsync(IInputStream src, IOutputStream dest);
  }
}
