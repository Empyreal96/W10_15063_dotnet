// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.KeyboardInputBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [WebHostHidden]
  public sealed class KeyboardInputBuffer : IKeyboardInputBuffer
  {
    [MethodImpl]
    public extern KeyboardInputBuffer();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern uint SelectionStart { [MethodImpl] get; }

    public extern uint SelectionLength { [MethodImpl] get; }

    [MethodImpl]
    public extern void Select(uint start, uint length);

    [MethodImpl]
    public extern void SelectFromTap(uint characterIndex);

    public extern CoreInputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<KeyboardInputBuffer, CoreTextChangedEventArgs> TextChanged;

    public extern event TypedEventHandler<KeyboardInputBuffer, CoreSelectionChangedEventArgs> SelectionChanged;
  }
}
