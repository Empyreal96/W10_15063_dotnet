// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchBoxResultSuggestionChosenEventArgs : 
    ISearchBoxResultSuggestionChosenEventArgs
  {
    [MethodImpl]
    public extern SearchBoxResultSuggestionChosenEventArgs();

    public extern string Tag { [MethodImpl] get; }

    public extern VirtualKeyModifiers KeyModifiers { [MethodImpl] get; }
  }
}
