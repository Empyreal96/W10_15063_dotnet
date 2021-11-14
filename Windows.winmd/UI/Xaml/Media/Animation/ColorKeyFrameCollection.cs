// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class ColorKeyFrameCollection : IVector<ColorKeyFrame>, IIterable<ColorKeyFrame>
  {
    [MethodImpl]
    public extern ColorKeyFrameCollection();

    [MethodImpl]
    public extern ColorKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ColorKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(ColorKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ColorKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, ColorKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ColorKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ColorKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(ColorKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<ColorKeyFrame> First();
  }
}
