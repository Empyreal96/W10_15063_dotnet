// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncActionProgressHandler`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1837385816, 3327, 17808, 174, 137, 149, 165, 165, 200, 180, 184)]
  public delegate void AsyncActionProgressHandler<TProgress>(
    IAsyncActionWithProgress<TProgress> asyncInfo,
    TProgress progressInfo);
}
