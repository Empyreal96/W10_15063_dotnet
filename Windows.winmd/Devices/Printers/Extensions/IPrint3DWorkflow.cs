// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3312415933, 13929, 19046, 171, 66, 200, 21, 25, 48, 205, 52)]
  [ExclusiveTo(typeof (Print3DWorkflow))]
  internal interface IPrint3DWorkflow
  {
    string DeviceID { get; }

    object GetPrintModelPackage();

    bool IsPrintReady { get; set; }

    event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrintRequestedEventArgs> PrintRequested;
  }
}
