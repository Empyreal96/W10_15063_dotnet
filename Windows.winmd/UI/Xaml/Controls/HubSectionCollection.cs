// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HubSectionCollection
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
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HubSectionCollection : IVector<HubSection>, IIterable<HubSection>
  {
    [MethodImpl]
    public extern HubSection GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HubSection> GetView();

    [MethodImpl]
    public extern bool IndexOf(HubSection value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HubSection value);

    [MethodImpl]
    public extern void InsertAt(uint index, HubSection value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HubSection value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HubSection[] items);

    [MethodImpl]
    public extern void ReplaceAll(HubSection[] items);

    [MethodImpl]
    public extern IIterator<HubSection> First();
  }
}
