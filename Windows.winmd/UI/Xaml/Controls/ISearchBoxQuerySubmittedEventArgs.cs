// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxQuerySubmittedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  [Guid(309235965, 15438, 19659, 154, 239, 71, 5, 209, 159, 229, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SearchBoxQuerySubmittedEventArgs))]
  internal interface ISearchBoxQuerySubmittedEventArgs
  {
    string QueryText { get; }

    string Language { get; }

    SearchQueryLinguisticDetails LinguisticDetails { get; }

    VirtualKeyModifiers KeyModifiers { get; }
  }
}
