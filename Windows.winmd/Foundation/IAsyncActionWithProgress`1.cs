// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncActionWithProgress`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(527282776, 59395, 18593, 149, 70, 235, 115, 83, 57, 136, 132)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncActionWithProgress<TProgress> : IAsyncInfo
  {
    AsyncActionProgressHandler<TProgress> Progress { [MethodImpl] set; [MethodImpl] get; }

    AsyncActionWithProgressCompletedHandler<TProgress> Completed { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    void GetResults();
  }
}
