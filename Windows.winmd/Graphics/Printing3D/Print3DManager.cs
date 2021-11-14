// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPrint3DManagerStatics), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Print3DManager : IPrint3DManager
  {
    public extern event TypedEventHandler<Print3DManager, Print3DTaskRequestedEventArgs> TaskRequested;

    [MethodImpl]
    public static extern Print3DManager GetForCurrentView();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowPrintUIAsync();
  }
}
