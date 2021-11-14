// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(265518780, 40393, 18101, 154, 206, 189, 149, 212, 86, 83, 69)]
  public interface ILaunchActivatedEventArgs2 : ILaunchActivatedEventArgs, IActivatedEventArgs
  {
    TileActivatedInfo TileActivatedInfo { get; }
  }
}
