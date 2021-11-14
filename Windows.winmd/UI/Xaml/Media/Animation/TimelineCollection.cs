// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.TimelineCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class TimelineCollection : IVector<Timeline>, IIterable<Timeline>
  {
    [MethodImpl]
    public extern TimelineCollection();

    [MethodImpl]
    public extern Timeline GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Timeline> GetView();

    [MethodImpl]
    public extern bool IndexOf(Timeline value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Timeline value);

    [MethodImpl]
    public extern void InsertAt(uint index, Timeline value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Timeline value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Timeline[] items);

    [MethodImpl]
    public extern void ReplaceAll(Timeline[] items);

    [MethodImpl]
    public extern IIterator<Timeline> First();
  }
}
