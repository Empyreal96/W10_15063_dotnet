// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyObjectCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDependencyObjectCollectionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class DependencyObjectCollection : 
    DependencyObject,
    IObservableVector<DependencyObject>,
    IVector<DependencyObject>,
    IIterable<DependencyObject>
  {
    [MethodImpl]
    public extern DependencyObjectCollection();

    public extern event VectorChangedEventHandler<DependencyObject> VectorChanged;

    [MethodImpl]
    public extern DependencyObject GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<DependencyObject> GetView();

    [MethodImpl]
    public extern bool IndexOf(DependencyObject value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, DependencyObject value);

    [MethodImpl]
    public extern void InsertAt(uint index, DependencyObject value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(DependencyObject value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] DependencyObject[] items);

    [MethodImpl]
    public extern void ReplaceAll(DependencyObject[] items);

    [MethodImpl]
    public extern IIterator<DependencyObject> First();
  }
}
