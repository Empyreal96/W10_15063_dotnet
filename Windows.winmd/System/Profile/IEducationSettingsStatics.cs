// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IEducationSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (EducationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4233359599, 19774, 19987, 155, 35, 80, 95, 77, 9, 30, 146)]
  internal interface IEducationSettingsStatics
  {
    bool IsEducationEnvironment { get; }
  }
}
