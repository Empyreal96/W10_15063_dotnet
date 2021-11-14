// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IDeviceAccountConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ExclusiveTo(typeof (DeviceAccountConfiguration))]
  [Guid(2902533027, 64476, 19739, 190, 67, 90, 39, 234, 74, 27, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceAccountConfiguration
  {
    string AccountName { get; set; }

    string DeviceAccountTypeId { get; set; }

    DeviceAccountServerType ServerType { get; set; }

    string EmailAddress { get; set; }

    string Domain { get; set; }

    bool EmailSyncEnabled { get; set; }

    bool ContactsSyncEnabled { get; set; }

    bool CalendarSyncEnabled { get; set; }

    string IncomingServerAddress { get; set; }

    int IncomingServerPort { get; set; }

    bool IncomingServerRequiresSsl { get; set; }

    string IncomingServerUsername { get; set; }

    string OutgoingServerAddress { get; set; }

    int OutgoingServerPort { get; set; }

    bool OutgoingServerRequiresSsl { get; set; }

    string OutgoingServerUsername { get; set; }
  }
}
