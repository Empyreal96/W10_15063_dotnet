// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncOperationWithProgress`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(3050321623, 58007, 18831, 186, 96, 2, 137, 231, 110, 35, 221)]
  public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo
  {
    AsyncOperationProgressHandler<TResult, TProgress> Progress { [MethodImpl] set; [MethodImpl] get; }

    AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    TResult GetResults();
  }
}
