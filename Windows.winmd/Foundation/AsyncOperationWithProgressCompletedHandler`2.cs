// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationWithProgressCompletedHandler`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(3898471453, 27303, 18147, 168, 226, 240, 9, 216, 64, 198, 39)]
  public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>(
    IAsyncOperationWithProgress<TResult, TProgress> asyncInfo,
    AsyncStatus asyncStatus);
}
