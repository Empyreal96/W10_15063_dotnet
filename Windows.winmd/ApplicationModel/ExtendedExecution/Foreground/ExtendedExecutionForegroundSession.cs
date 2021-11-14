// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ExtendedExecutionForegroundSession : 
    IExtendedExecutionForegroundSession,
    IClosable
  {
    [MethodImpl]
    public extern ExtendedExecutionForegroundSession();

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<object, ExtendedExecutionForegroundRevokedEventArgs> Revoked;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ExtendedExecutionForegroundResult> RequestExtensionAsync();

    public extern ExtendedExecutionForegroundReason Reason { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Close();
  }
}
