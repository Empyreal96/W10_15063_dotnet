// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationProgressHandler`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(1432946946, 2731, 16922, 135, 120, 248, 206, 80, 38, 215, 88)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationProgressHandler<TResult, TProgress>(
    IAsyncOperationWithProgress<TResult, TProgress> asyncInfo,
    TProgress progressInfo);
}
