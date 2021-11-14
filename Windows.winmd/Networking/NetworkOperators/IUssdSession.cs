// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IUssdSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (UssdSession))]
  [Guid(798674818, 8194, 19805, 191, 129, 42, 186, 27, 75, 228, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUssdSession
  {
    IAsyncOperation<UssdReply> SendMessageAndGetReplyAsync(
      UssdMessage message);

    void Close();
  }
}
