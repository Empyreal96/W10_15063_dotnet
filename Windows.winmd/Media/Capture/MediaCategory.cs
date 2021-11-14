// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCategory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCategory
  {
    Other,
    Communications,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Media,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GameChat,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Speech,
  }
}
