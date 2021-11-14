// Decompiled with JetBrains decompiler
// Type: Windows.Media.IShuffleEnabledChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (ShuffleEnabledChangeRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1236636670, 20432, 18022, 163, 20, 192, 224, 25, 64, 211, 2)]
  internal interface IShuffleEnabledChangeRequestedEventArgs
  {
    bool RequestedShuffleEnabled { get; }
  }
}
