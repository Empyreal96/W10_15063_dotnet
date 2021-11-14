// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.IPhoneCallOrigin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Provider
{
  [Guid(543241337, 3833, 17492, 135, 28, 175, 182, 106, 20, 182, 165)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallOrigin))]
  internal interface IPhoneCallOrigin
  {
    string Category { get; set; }

    string CategoryDescription { get; set; }

    string Location { get; set; }
  }
}
