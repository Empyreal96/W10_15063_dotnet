// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DoubleKeyFrameCollection : IVector<DoubleKeyFrame>, IIterable<DoubleKeyFrame>
  {
    [MethodImpl]
    public extern DoubleKeyFrameCollection();

    [MethodImpl]
    public extern DoubleKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<DoubleKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(DoubleKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, DoubleKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, DoubleKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(DoubleKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] DoubleKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(DoubleKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<DoubleKeyFrame> First();
  }
}
