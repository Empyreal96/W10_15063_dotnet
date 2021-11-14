// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProviderOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(432994615, 54325, 16761, 182, 175, 20, 224, 73, 43, 105, 246)]
  [ExclusiveTo(typeof (ShareProviderOperation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareProviderOperation
  {
    DataPackageView Data { get; }

    ShareProvider Provider { get; }

    void ReportCompleted();
  }
}
