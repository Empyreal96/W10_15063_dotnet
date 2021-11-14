// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ShareOperation : IShareOperation, IShareOperation2
  {
    public extern DataPackageView Data { [MethodImpl] get; }

    public extern string QuickLinkId { [MethodImpl] get; }

    [MethodImpl]
    public extern void RemoveThisQuickLink();

    [MethodImpl]
    public extern void ReportStarted();

    [MethodImpl]
    public extern void ReportDataRetrieved();

    [MethodImpl]
    public extern void ReportSubmittedBackgroundTask();

    [Overload("ReportCompletedWithQuickLink")]
    [MethodImpl]
    public extern void ReportCompleted(QuickLink quicklink);

    [Overload("ReportCompleted")]
    [MethodImpl]
    public extern void ReportCompleted();

    [MethodImpl]
    public extern void ReportError(string value);

    [MethodImpl]
    public extern void DismissUI();
  }
}
