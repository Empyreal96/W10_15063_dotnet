// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IBackgroundActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(2870263520, 59232, 17422, 169, 28, 68, 121, 109, 227, 169, 45)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IBackgroundActivatedEventArgs
  {
    IBackgroundTaskInstance TaskInstance { get; }
  }
}
