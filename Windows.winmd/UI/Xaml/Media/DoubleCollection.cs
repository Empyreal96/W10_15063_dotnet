// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.DoubleCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DoubleCollection : IVector<double>, IIterable<double>
  {
    [MethodImpl]
    public extern DoubleCollection();

    [MethodImpl]
    public extern double GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<double> GetView();

    [MethodImpl]
    public extern bool IndexOf(double value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, double value);

    [MethodImpl]
    public extern void InsertAt(uint index, double value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(double value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] double[] items);

    [MethodImpl]
    public extern void ReplaceAll(double[] items);

    [MethodImpl]
    public extern IIterator<double> First();
  }
}
