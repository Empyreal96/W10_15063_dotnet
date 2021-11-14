// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflowPrintRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (Print3DWorkflowPrintRequestedEventArgs))]
  [Guid(435734616, 23240, 19285, 138, 95, 230, 21, 103, 218, 251, 77)]
  internal interface IPrint3DWorkflowPrintRequestedEventArgs
  {
    Print3DWorkflowStatus Status { get; }

    void SetExtendedStatus(Print3DWorkflowDetail value);

    void SetSource(object source);

    void SetSourceChanged(bool value);
  }
}
