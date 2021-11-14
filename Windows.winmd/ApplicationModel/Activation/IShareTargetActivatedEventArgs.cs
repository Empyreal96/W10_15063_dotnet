// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IShareTargetActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1272641992, 52658, 19147, 191, 195, 102, 72, 86, 51, 120, 236)]
  public interface IShareTargetActivatedEventArgs : IActivatedEventArgs
  {
    ShareOperation ShareOperation { get; }
  }
}
