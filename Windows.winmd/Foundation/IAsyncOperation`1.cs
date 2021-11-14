// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncOperation`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(2680336571, 58438, 17634, 170, 97, 156, 171, 143, 99, 106, 242)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncOperation<TResult> : IAsyncInfo
  {
    AsyncOperationCompletedHandler<TResult> Completed { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    TResult GetResults();
  }
}
