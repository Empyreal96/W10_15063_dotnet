// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3850438325, 5471, 19092, 167, 66, 199, 224, 143, 78, 24, 140)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContinuationActivatedEventArgs : IActivatedEventArgs
  {
    ValueSet ContinuationData { get; }
  }
}
