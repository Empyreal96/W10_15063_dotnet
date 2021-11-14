// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.FdnAccessManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Static(typeof (IFdnAccessManagerStatics), 65536, "Windows.Networking.NetworkOperators.NetworkOperatorsFdnContract")]
  [ContractVersion(typeof (NetworkOperatorsFdnContract), 65536)]
  public static class FdnAccessManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestUnlockAsync(
      string contactListId);
  }
}
