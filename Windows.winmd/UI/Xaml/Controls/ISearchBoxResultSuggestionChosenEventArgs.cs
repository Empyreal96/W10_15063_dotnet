// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxResultSuggestionChosenEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchBoxResultSuggestionChosenEventArgs))]
  [Guid(412191779, 58563, 18018, 160, 59, 208, 84, 255, 208, 249, 5)]
  internal interface ISearchBoxResultSuggestionChosenEventArgs
  {
    string Tag { get; }

    VirtualKeyModifiers KeyModifiers { get; }
  }
}
