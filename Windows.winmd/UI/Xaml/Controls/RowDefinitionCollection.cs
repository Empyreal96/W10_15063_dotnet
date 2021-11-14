// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RowDefinitionCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class RowDefinitionCollection : IVector<RowDefinition>, IIterable<RowDefinition>
  {
    [MethodImpl]
    public extern RowDefinition GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<RowDefinition> GetView();

    [MethodImpl]
    public extern bool IndexOf(RowDefinition value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, RowDefinition value);

    [MethodImpl]
    public extern void InsertAt(uint index, RowDefinition value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(RowDefinition value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] RowDefinition[] items);

    [MethodImpl]
    public extern void ReplaceAll(RowDefinition[] items);

    [MethodImpl]
    public extern IIterator<RowDefinition> First();
  }
}
