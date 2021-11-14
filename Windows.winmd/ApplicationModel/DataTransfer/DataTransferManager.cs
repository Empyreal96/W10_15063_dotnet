// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataTransferManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDataTransferManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDataTransferManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class DataTransferManager : IDataTransferManager, IDataTransferManager2
  {
    public extern event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

    public extern event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;

    public extern event TypedEventHandler<DataTransferManager, ShareProvidersRequestedEventArgs> ShareProvidersRequested;

    [MethodImpl]
    public static extern bool IsSupported();

    [MethodImpl]
    public static extern void ShowShareUI();

    [MethodImpl]
    public static extern DataTransferManager GetForCurrentView();
  }
}
