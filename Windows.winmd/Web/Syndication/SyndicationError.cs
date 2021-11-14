// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISyndicationErrorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class SyndicationError
  {
    [MethodImpl]
    public static extern SyndicationErrorStatus GetStatus(int hresult);
  }
}
