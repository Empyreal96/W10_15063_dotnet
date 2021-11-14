// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.Preview.ISoundLevelBrokerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SoundLevelBroker))]
  [Guid(1784887649, 56301, 17996, 160, 154, 51, 65, 47, 92, 170, 63)]
  internal interface ISoundLevelBrokerStatics
  {
    SoundLevel SoundLevel { get; }

    event EventHandler<object> SoundLevelChanged;
  }
}
