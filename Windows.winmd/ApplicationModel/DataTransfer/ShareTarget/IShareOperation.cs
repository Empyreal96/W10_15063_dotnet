// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [Guid(575060664, 53496, 16833, 168, 42, 65, 55, 219, 101, 4, 251)]
  [ExclusiveTo(typeof (ShareOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IShareOperation
  {
    DataPackageView Data { get; }

    string QuickLinkId { get; }

    void RemoveThisQuickLink();

    void ReportStarted();

    void ReportDataRetrieved();

    void ReportSubmittedBackgroundTask();

    [Overload("ReportCompletedWithQuickLink")]
    void ReportCompleted(QuickLink quicklink);

    [Overload("ReportCompleted")]
    void ReportCompleted();

    void ReportError(string value);
  }
}
