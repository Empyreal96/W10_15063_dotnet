// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class CodecQuery : ICodecQuery
  {
    [MethodImpl]
    public extern CodecQuery();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<CodecInfo>> FindAllAsync(
      CodecKind kind,
      CodecCategory category,
      string subType);
  }
}
