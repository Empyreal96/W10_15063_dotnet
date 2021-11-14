// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsTimestampInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class CmsTimestampInfo : ICmsTimestampInfo
  {
    public extern Certificate SigningCertificate { [MethodImpl] get; }

    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
