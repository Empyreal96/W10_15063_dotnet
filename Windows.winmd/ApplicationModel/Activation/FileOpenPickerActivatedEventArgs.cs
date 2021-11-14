// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileOpenPickerActivatedEventArgs : 
    IFileOpenPickerActivatedEventArgs,
    IActivatedEventArgs,
    IFileOpenPickerActivatedEventArgs2,
    IActivatedEventArgsWithUser
  {
    public extern FileOpenPickerUI FileOpenPickerUI { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }
  }
}
