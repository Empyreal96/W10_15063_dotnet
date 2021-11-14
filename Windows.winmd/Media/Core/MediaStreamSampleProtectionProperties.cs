// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSampleProtectionProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  public sealed class MediaStreamSampleProtectionProperties : IMediaStreamSampleProtectionProperties
  {
    [MethodImpl]
    public extern void SetKeyIdentifier(byte[] value);

    [MethodImpl]
    public extern void GetKeyIdentifier(out byte[] value);

    [MethodImpl]
    public extern void SetInitializationVector(byte[] value);

    [MethodImpl]
    public extern void GetInitializationVector(out byte[] value);

    [MethodImpl]
    public extern void SetSubSampleMapping(byte[] value);

    [MethodImpl]
    public extern void GetSubSampleMapping(out byte[] value);
  }
}
