// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.HtmlFormatHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHtmlFormatHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class HtmlFormatHelper
  {
    [MethodImpl]
    public static extern string GetStaticFragment(string htmlFormat);

    [MethodImpl]
    public static extern string CreateHtmlFormat(string htmlFragment);
  }
}
