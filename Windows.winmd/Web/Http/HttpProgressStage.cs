// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpProgressStage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpProgressStage
  {
    None = 0,
    DetectingProxy = 10, // 0x0000000A
    ResolvingName = 20, // 0x00000014
    ConnectingToServer = 30, // 0x0000001E
    NegotiatingSsl = 40, // 0x00000028
    SendingHeaders = 50, // 0x00000032
    SendingContent = 60, // 0x0000003C
    WaitingForResponse = 70, // 0x00000046
    ReceivingHeaders = 80, // 0x00000050
    ReceivingContent = 90, // 0x0000005A
  }
}
