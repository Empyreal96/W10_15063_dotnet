// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareProvidersRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ShareProvidersRequestedEventArgs : IShareProvidersRequestedEventArgs
  {
    public extern IVector<ShareProvider> Providers { [MethodImpl] get; }

    public extern DataPackageView Data { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
