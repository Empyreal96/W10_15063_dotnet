// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.UIElementCollection
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
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UIElementCollection : 
    IVector<UIElement>,
    IIterable<UIElement>,
    IUIElementCollection
  {
    [MethodImpl]
    public extern UIElement GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<UIElement> GetView();

    [MethodImpl]
    public extern bool IndexOf(UIElement value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, UIElement value);

    [MethodImpl]
    public extern void InsertAt(uint index, UIElement value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(UIElement value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] UIElement[] items);

    [MethodImpl]
    public extern void ReplaceAll(UIElement[] items);

    [MethodImpl]
    public extern IIterator<UIElement> First();

    [MethodImpl]
    public extern void Move(uint oldIndex, uint newIndex);
  }
}
