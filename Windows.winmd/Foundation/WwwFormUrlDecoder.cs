// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.WwwFormUrlDecoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWwwFormUrlDecoderRuntimeClassFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WwwFormUrlDecoder : 
    IWwwFormUrlDecoderRuntimeClass,
    IVectorView<IWwwFormUrlDecoderEntry>,
    IIterable<IWwwFormUrlDecoderEntry>
  {
    [MethodImpl]
    public extern WwwFormUrlDecoder(string query);

    [MethodImpl]
    public extern string GetFirstValueByName(string name);

    [MethodImpl]
    public extern IIterator<IWwwFormUrlDecoderEntry> First();

    [MethodImpl]
    public extern IWwwFormUrlDecoderEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(IWwwFormUrlDecoderEntry value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IWwwFormUrlDecoderEntry[] items);
  }
}
