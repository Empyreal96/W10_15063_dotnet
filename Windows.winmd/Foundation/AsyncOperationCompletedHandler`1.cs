// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationCompletedHandler`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(4242337836, 58840, 17528, 145, 90, 77, 144, 183, 75, 131, 165)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationCompletedHandler<TResult>(
    IAsyncOperation<TResult> asyncInfo,
    AsyncStatus asyncStatus);
}
