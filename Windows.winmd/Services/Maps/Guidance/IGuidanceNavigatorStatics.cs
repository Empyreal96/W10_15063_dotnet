// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceNavigatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceNavigator))]
  [Guid(16618771, 17494, 20070, 161, 67, 58, 221, 107, 224, 132, 38)]
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  internal interface IGuidanceNavigatorStatics
  {
    GuidanceNavigator GetCurrent();
  }
}
