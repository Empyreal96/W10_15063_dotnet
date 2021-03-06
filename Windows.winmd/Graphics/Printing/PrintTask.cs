// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTask : IPrintTask, IPrintTaskTargetDeviceSupport, IPrintTask2
  {
    public extern DataPackagePropertySet Properties { [MethodImpl] get; }

    public extern IPrintDocumentSource Source { [MethodImpl] get; }

    public extern PrintTaskOptions Options { [MethodImpl] get; }

    public extern event TypedEventHandler<PrintTask, object> Previewing;

    public extern event TypedEventHandler<PrintTask, object> Submitting;

    public extern event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

    public extern event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;

    public extern bool IsPrinterTargetEnabled { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Is3DManufacturingTargetEnabled { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsPreviewEnabled { [MethodImpl] set; [MethodImpl] get; }
  }
}
