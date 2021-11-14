// Decompiled with JetBrains decompiler
// Type: Windows.Phone.ApplicationModel.IApplicationProfileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.ApplicationModel
{
  [ExclusiveTo(typeof (ApplicationProfile))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3573582516, 32378, 4577, 167, 242, 176, 161, 72, 36, 1, 155)]
  internal interface IApplicationProfileStatics
  {
    ApplicationProfileModes Modes { get; }
  }
}
