// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TriggerActionCollection
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TriggerActionCollection : IVector<TriggerAction>, IIterable<TriggerAction>
  {
    [MethodImpl]
    public extern TriggerActionCollection();

    [MethodImpl]
    public extern TriggerAction GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<TriggerAction> GetView();

    [MethodImpl]
    public extern bool IndexOf(TriggerAction value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, TriggerAction value);

    [MethodImpl]
    public extern void InsertAt(uint index, TriggerAction value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(TriggerAction value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] TriggerAction[] items);

    [MethodImpl]
    public extern void ReplaceAll(TriggerAction[] items);

    [MethodImpl]
    public extern IIterator<TriggerAction> First();
  }
}
