// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUISearchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Search;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (WebUISearchActivatedEventsContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUISearchActivatedEventArgs : 
    ISearchActivatedEventArgs,
    IActivatedEventArgs,
    ISearchActivatedEventArgsWithLinguisticDetails,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral
  {
    public extern string QueryText { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    public extern SearchPaneQueryLinguisticDetails LinguisticDetails { [MethodImpl] get; }

    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }
  }
}
