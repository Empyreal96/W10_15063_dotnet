// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(1641546311, 27894, 20397, 132, 226, 165, 232, 46, 45, 76, 235)]
  [ExclusiveTo(typeof (PrintTask))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTask
  {
    DataPackagePropertySet Properties { get; }

    IPrintDocumentSource Source { get; }

    PrintTaskOptions Options { get; }

    event TypedEventHandler<PrintTask, object> Previewing;

    event TypedEventHandler<PrintTask, object> Submitting;

    event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

    event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;
  }
}
