// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeometryCollection
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class GeometryCollection : IVector<Geometry>, IIterable<Geometry>
  {
    [MethodImpl]
    public extern GeometryCollection();

    [MethodImpl]
    public extern Geometry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Geometry> GetView();

    [MethodImpl]
    public extern bool IndexOf(Geometry value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Geometry value);

    [MethodImpl]
    public extern void InsertAt(uint index, Geometry value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Geometry value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Geometry[] items);

    [MethodImpl]
    public extern void ReplaceAll(Geometry[] items);

    [MethodImpl]
    public extern IIterator<Geometry> First();
  }
}
