// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBoxQuerySubmittedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2027729174, 33162, 19637, 188, 167, 56, 44, 230, 221, 201, 13)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutoSuggestBoxQuerySubmittedEventArgs))]
  internal interface IAutoSuggestBoxQuerySubmittedEventArgs
  {
    string QueryText { get; }

    object ChosenSuggestion { get; }
  }
}
