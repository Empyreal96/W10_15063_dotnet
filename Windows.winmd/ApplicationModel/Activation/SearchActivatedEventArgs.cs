// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.SearchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchActivatedEventArgs : 
    ISearchActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    ISearchActivatedEventArgsWithLinguisticDetails,
    IViewSwitcherProvider,
    IActivatedEventArgsWithUser
  {
    public extern string QueryText { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    public extern SearchPaneQueryLinguisticDetails LinguisticDetails { [MethodImpl] get; }

    public extern ActivationViewSwitcher ViewSwitcher { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }
  }
}
