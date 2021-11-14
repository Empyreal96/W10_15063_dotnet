// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientStopCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class GradientStopCollection : IVector<GradientStop>, IIterable<GradientStop>
  {
    [MethodImpl]
    public extern GradientStopCollection();

    [MethodImpl]
    public extern GradientStop GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<GradientStop> GetView();

    [MethodImpl]
    public extern bool IndexOf(GradientStop value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, GradientStop value);

    [MethodImpl]
    public extern void InsertAt(uint index, GradientStop value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(GradientStop value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] GradientStop[] items);

    [MethodImpl]
    public extern void ReplaceAll(GradientStop[] items);

    [MethodImpl]
    public extern IIterator<GradientStop> First();
  }
}
