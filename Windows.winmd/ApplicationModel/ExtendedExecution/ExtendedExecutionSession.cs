// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ExtendedExecutionSession : IExtendedExecutionSession, IClosable
  {
    [MethodImpl]
    public extern ExtendedExecutionSession();

    public extern ExtendedExecutionReason Reason { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern uint PercentProgress { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<object, ExtendedExecutionRevokedEventArgs> Revoked;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ExtendedExecutionResult> RequestExtensionAsync();

    [MethodImpl]
    public extern void Close();
  }
}
