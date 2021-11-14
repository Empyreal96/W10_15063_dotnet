// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.IExtendedExecutionSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2945485357, 4491, 18673, 147, 8, 12, 79, 196, 30, 32, 15)]
  [ExclusiveTo(typeof (ExtendedExecutionSession))]
  internal interface IExtendedExecutionSession : IClosable
  {
    ExtendedExecutionReason Reason { get; set; }

    string Description { get; set; }

    uint PercentProgress { get; set; }

    event TypedEventHandler<object, ExtendedExecutionRevokedEventArgs> Revoked;

    [RemoteAsync]
    IAsyncOperation<ExtendedExecutionResult> RequestExtensionAsync();
  }
}
