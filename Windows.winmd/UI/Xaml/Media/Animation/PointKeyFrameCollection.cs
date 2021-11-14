// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointKeyFrameCollection
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class PointKeyFrameCollection : IVector<PointKeyFrame>, IIterable<PointKeyFrame>
  {
    [MethodImpl]
    public extern PointKeyFrameCollection();

    [MethodImpl]
    public extern PointKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<PointKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(PointKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, PointKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, PointKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(PointKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] PointKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(PointKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<PointKeyFrame> First();
  }
}
