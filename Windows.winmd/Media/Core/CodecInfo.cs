// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class CodecInfo : ICodecInfo
  {
    public extern CodecKind Kind { [MethodImpl] get; }

    public extern CodecCategory Category { [MethodImpl] get; }

    public extern IVectorView<string> Subtypes { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern bool IsTrusted { [MethodImpl] get; }
  }
}
