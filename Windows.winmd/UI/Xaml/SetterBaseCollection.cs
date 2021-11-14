// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SetterBaseCollection
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SetterBaseCollection : 
    ISetterBaseCollection,
    IVector<SetterBase>,
    IIterable<SetterBase>
  {
    [MethodImpl]
    public extern SetterBaseCollection();

    public extern bool IsSealed { [MethodImpl] get; }

    [MethodImpl]
    public extern SetterBase GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SetterBase> GetView();

    [MethodImpl]
    public extern bool IndexOf(SetterBase value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SetterBase value);

    [MethodImpl]
    public extern void InsertAt(uint index, SetterBase value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SetterBase value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SetterBase[] items);

    [MethodImpl]
    public extern void ReplaceAll(SetterBase[] items);

    [MethodImpl]
    public extern IIterator<SetterBase> First();
  }
}
