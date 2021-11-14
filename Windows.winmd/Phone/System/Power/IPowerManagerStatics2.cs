// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Power.IPowerManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Power
{
  [Guid(1499608783, 6424, 17745, 164, 102, 197, 26, 174, 55, 59, 248)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (PowerManager))]
  internal interface IPowerManagerStatics2
  {
    bool PowerSavingModeEnabled { get; }
  }
}
