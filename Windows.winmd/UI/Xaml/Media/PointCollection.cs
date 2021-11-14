// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PointCollection
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
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointCollection : IVector<Point>, IIterable<Point>
  {
    [MethodImpl]
    public extern PointCollection();

    [MethodImpl]
    public extern Point GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Point> GetView();

    [MethodImpl]
    public extern bool IndexOf(Point value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Point value);

    [MethodImpl]
    public extern void InsertAt(uint index, Point value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Point value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Point[] items);

    [MethodImpl]
    public extern void ReplaceAll(Point[] items);

    [MethodImpl]
    public extern IIterator<Point> First();
  }
}
