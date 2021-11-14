// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PathSegmentCollection
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
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PathSegmentCollection : IVector<PathSegment>, IIterable<PathSegment>
  {
    [MethodImpl]
    public extern PathSegmentCollection();

    [MethodImpl]
    public extern PathSegment GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<PathSegment> GetView();

    [MethodImpl]
    public extern bool IndexOf(PathSegment value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, PathSegment value);

    [MethodImpl]
    public extern void InsertAt(uint index, PathSegment value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(PathSegment value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] PathSegment[] items);

    [MethodImpl]
    public extern void ReplaceAll(PathSegment[] items);

    [MethodImpl]
    public extern IIterator<PathSegment> First();
  }
}
