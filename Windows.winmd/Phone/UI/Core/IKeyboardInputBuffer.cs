// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.IKeyboardInputBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(930541203, 32889, 16588, 140, 47, 167, 169, 151, 207, 157, 110)]
  [WebHostHidden]
  [ExclusiveTo(typeof (KeyboardInputBuffer))]
  internal interface IKeyboardInputBuffer
  {
    string Text { get; set; }

    uint SelectionStart { get; }

    uint SelectionLength { get; }

    void Select(uint start, uint length);

    void SelectFromTap(uint characterIndex);

    CoreInputScope InputScope { get; set; }

    event TypedEventHandler<KeyboardInputBuffer, CoreTextChangedEventArgs> TextChanged;

    event TypedEventHandler<KeyboardInputBuffer, CoreSelectionChangedEventArgs> SelectionChanged;
  }
}
