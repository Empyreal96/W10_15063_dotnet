// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ICodecInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CodecInfo))]
  [Guid(1374199685, 60055, 18844, 134, 172, 76, 229, 231, 63, 58, 66)]
  internal interface ICodecInfo
  {
    CodecKind Kind { get; }

    CodecCategory Category { get; }

    IVectorView<string> Subtypes { get; }

    string DisplayName { get; }

    bool IsTrusted { get; }
  }
}
