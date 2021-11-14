// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBoxTextChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(980382292, 7893, 19397, 160, 96, 101, 85, 48, 188, 166, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutoSuggestBoxTextChangedEventArgs))]
  internal interface IAutoSuggestBoxTextChangedEventArgs
  {
    AutoSuggestionBoxTextChangeReason Reason { get; set; }

    bool CheckCurrent();
  }
}
