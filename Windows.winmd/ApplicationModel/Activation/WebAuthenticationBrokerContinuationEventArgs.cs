// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAuthenticationBrokerContinuationEventArgs : 
    IWebAuthenticationBrokerContinuationEventArgs,
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    public extern WebAuthenticationResult WebAuthenticationResult { [MethodImpl] get; }

    public extern ValueSet ContinuationData { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }
  }
}
