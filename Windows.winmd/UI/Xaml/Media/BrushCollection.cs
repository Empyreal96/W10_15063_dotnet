// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.BrushCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BrushCollection : IVector<Brush>, IIterable<Brush>
  {
    [MethodImpl]
    public extern BrushCollection();

    [MethodImpl]
    public extern Brush GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Brush> GetView();

    [MethodImpl]
    public extern bool IndexOf(Brush value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Brush value);

    [MethodImpl]
    public extern void InsertAt(uint index, Brush value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Brush value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Brush[] items);

    [MethodImpl]
    public extern void ReplaceAll(Brush[] items);

    [MethodImpl]
    public extern IIterator<Brush> First();
  }
}
