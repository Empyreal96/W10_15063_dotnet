// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(2895838009, 7657, 20114, 183, 143, 5, 129, 168, 127, 110, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccount))]
  internal interface IWebAccountFactory
  {
    WebAccount CreateWebAccount(
      WebAccountProvider webAccountProvider,
      string userName,
      WebAccountState state);
  }
}
