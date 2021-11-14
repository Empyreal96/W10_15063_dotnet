// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3496915399, 14341, 20171, 183, 87, 108, 241, 94, 38, 254, 243)]
  public interface ICachedFileUpdaterActivatedEventArgs : IActivatedEventArgs
  {
    CachedFileUpdaterUI CachedFileUpdaterUI { get; }
  }
}
