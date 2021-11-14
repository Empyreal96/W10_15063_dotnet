// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ObjectKeyFrameCollection
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ObjectKeyFrameCollection : IVector<ObjectKeyFrame>, IIterable<ObjectKeyFrame>
  {
    [MethodImpl]
    public extern ObjectKeyFrameCollection();

    [MethodImpl]
    public extern ObjectKeyFrame GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ObjectKeyFrame> GetView();

    [MethodImpl]
    public extern bool IndexOf(ObjectKeyFrame value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, ObjectKeyFrame value);

    [MethodImpl]
    public extern void InsertAt(uint index, ObjectKeyFrame value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(ObjectKeyFrame value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ObjectKeyFrame[] items);

    [MethodImpl]
    public extern void ReplaceAll(ObjectKeyFrame[] items);

    [MethodImpl]
    public extern IIterator<ObjectKeyFrame> First();
  }
}
