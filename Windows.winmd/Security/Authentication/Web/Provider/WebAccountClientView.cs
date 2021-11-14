// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountClientView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IWebAccountClientViewFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebAccountClientView : IWebAccountClientView
  {
    [MethodImpl]
    public extern WebAccountClientView(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri);

    [MethodImpl]
    public extern WebAccountClientView(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri,
      string accountPairwiseId);

    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    public extern WebAccountClientViewType Type { [MethodImpl] get; }

    public extern string AccountPairwiseId { [MethodImpl] get; }
  }
}
