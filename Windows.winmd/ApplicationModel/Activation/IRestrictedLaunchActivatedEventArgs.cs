// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3770133633, 49091, 17220, 165, 218, 25, 253, 90, 39, 186, 174)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRestrictedLaunchActivatedEventArgs : IActivatedEventArgs
  {
    object SharedContext { get; }
  }
}
