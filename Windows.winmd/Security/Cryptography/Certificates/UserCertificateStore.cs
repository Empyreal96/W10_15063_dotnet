// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.UserCertificateStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserCertificateStore : IUserCertificateStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestAddAsync(Certificate certificate);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync(Certificate certificate);

    public extern string Name { [MethodImpl] get; }
  }
}
