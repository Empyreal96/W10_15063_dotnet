// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3479508755, 52488, 20440, 182, 151, 162, 129, 182, 84, 78, 46)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IActivatedEventArgs
  {
    ActivationKind Kind { get; }

    ApplicationExecutionState PreviousExecutionState { get; }

    SplashScreen SplashScreen { get; }
  }
}
