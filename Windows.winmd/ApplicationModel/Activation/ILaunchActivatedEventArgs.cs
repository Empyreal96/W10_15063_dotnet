// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4224269862, 41290, 19279, 130, 176, 51, 190, 217, 32, 175, 82)]
  public interface ILaunchActivatedEventArgs : IActivatedEventArgs
  {
    string Arguments { get; }

    string TileId { get; }
  }
}
