// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3462997439, 4298, 16584, 169, 202, 197, 201, 101, 1, 134, 110)]
  internal interface IAppDiagnosticInfoStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoAsync();
  }
}
