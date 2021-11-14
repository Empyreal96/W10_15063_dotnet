// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncActionWithProgressCompletedHandler`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(2617417617, 52356, 17661, 172, 38, 10, 108, 78, 85, 82, 129)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncActionWithProgressCompletedHandler<TProgress>(
    IAsyncActionWithProgress<TProgress> asyncInfo,
    AsyncStatus asyncStatus);
}
