// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ItemCollection : IObservableVector<object>, IVector<object>, IIterable<object>
  {
    public extern event VectorChangedEventHandler<object> VectorChanged;

    [MethodImpl]
    public extern object GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<object> GetView();

    [MethodImpl]
    public extern bool IndexOf(object value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, object value);

    [MethodImpl]
    public extern void InsertAt(uint index, object value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(object value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] object[] items);

    [MethodImpl]
    public extern void ReplaceAll(object[] items);

    [MethodImpl]
    public extern IIterator<object> First();
  }
}
