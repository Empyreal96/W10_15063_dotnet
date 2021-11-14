// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSampleProtectionProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSampleProtectionProperties))]
  [Guid(1320714898, 60639, 18750, 132, 29, 221, 74, 221, 124, 172, 162)]
  internal interface IMediaStreamSampleProtectionProperties
  {
    void SetKeyIdentifier(byte[] value);

    void GetKeyIdentifier(out byte[] value);

    void SetInitializationVector(byte[] value);

    void GetInitializationVector(out byte[] value);

    void SetSubSampleMapping(byte[] value);

    void GetSubSampleMapping(out byte[] value);
  }
}
