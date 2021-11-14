// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseSourceBufferList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MseSourceBufferList : IMseSourceBufferList
  {
    public extern event TypedEventHandler<MseSourceBufferList, object> SourceBufferAdded;

    public extern event TypedEventHandler<MseSourceBufferList, object> SourceBufferRemoved;

    public extern IVectorView<MseSourceBuffer> Buffers { [MethodImpl] get; }
  }
}
