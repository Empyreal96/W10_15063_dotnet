// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceNavigatorStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Guid(1422246882, 30596, 19589, 140, 149, 208, 198, 239, 180, 57, 101)]
  [ContractVersion(typeof (GuidanceContract), 131072)]
  [ExclusiveTo(typeof (GuidanceNavigator))]
  [WebHostHidden]
  internal interface IGuidanceNavigatorStatics2
  {
    bool UseAppProvidedVoice { get; }
  }
}
