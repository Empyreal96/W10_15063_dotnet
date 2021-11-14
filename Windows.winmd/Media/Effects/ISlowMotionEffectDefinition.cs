// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ISlowMotionEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(889535696, 5996, 18275, 130, 196, 27, 2, 219, 227, 23, 55)]
  [ExclusiveTo(typeof (SlowMotionEffectDefinition))]
  internal interface ISlowMotionEffectDefinition : IVideoEffectDefinition
  {
    double TimeStretchRate { get; set; }
  }
}
