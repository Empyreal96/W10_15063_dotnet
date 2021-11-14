// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DTask))]
  [Guid(2363740288, 8472, 19496, 128, 222, 244, 38, 215, 1, 145, 174)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrint3DTask
  {
    Printing3D3MFPackage Source { get; }

    event TypedEventHandler<Print3DTask, object> Submitting;

    event TypedEventHandler<Print3DTask, Print3DTaskCompletedEventArgs> Completed;

    event TypedEventHandler<Print3DTask, Print3DTaskSourceChangedEventArgs> SourceChanged;
  }
}
