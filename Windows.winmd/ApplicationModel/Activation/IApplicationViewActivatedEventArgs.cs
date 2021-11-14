// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(2467098443, 47145, 16636, 136, 244, 133, 19, 232, 166, 71, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IApplicationViewActivatedEventArgs : IActivatedEventArgs
  {
    int CurrentlyShownApplicationViewId { get; }
  }
}
