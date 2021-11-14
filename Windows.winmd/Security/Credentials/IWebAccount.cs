// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1766276786, 32817, 18878, 128, 187, 150, 203, 70, 217, 154, 186)]
  public interface IWebAccount
  {
    WebAccountProvider WebAccountProvider { get; }

    string UserName { get; }

    WebAccountState State { get; }
  }
}
