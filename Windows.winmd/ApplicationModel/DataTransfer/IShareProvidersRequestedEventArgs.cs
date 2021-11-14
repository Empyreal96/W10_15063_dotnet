// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProvidersRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareProvidersRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4169724758, 41976, 20430, 133, 228, 136, 38, 230, 59, 231, 153)]
  internal interface IShareProvidersRequestedEventArgs
  {
    IVector<ShareProvider> Providers { get; }

    DataPackageView Data { get; }

    Deferral GetDeferral();
  }
}
