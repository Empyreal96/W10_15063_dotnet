﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIFileActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.System;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIFileActivatedEventArgs : 
    IFileActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IFileActivatedEventArgsWithNeighboringFiles,
    IActivatedEventArgsWithUser
  {
    public extern IVectorView<IStorageItem> Files { [MethodImpl] get; }

    public extern string Verb { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    public extern StorageFileQueryResult NeighboringFilesQuery { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }
  }
}
