// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.MemoryBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMemoryBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MemoryBuffer : IMemoryBuffer, IClosable
  {
    [MethodImpl]
    public extern MemoryBuffer([Range(0, 2147483647)] uint capacity);

    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
