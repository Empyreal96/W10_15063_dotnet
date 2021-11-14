// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.High)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapBuffer : IBitmapBuffer, IMemoryBuffer, IClosable
  {
    [MethodImpl]
    public extern int GetPlaneCount();

    [MethodImpl]
    public extern BitmapPlaneDescription GetPlaneDescription(int index);

    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
