// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsSignerInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CmsSignerInfo : ICmsSignerInfo
  {
    [MethodImpl]
    public extern CmsSignerInfo();

    public extern Certificate Certificate { [MethodImpl] get; [MethodImpl] set; }

    public extern string HashAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    public extern CmsTimestampInfo TimestampInfo { [MethodImpl] get; }
  }
}
