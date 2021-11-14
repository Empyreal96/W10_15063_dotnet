// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountSyncScheduleKind
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum DeviceAccountSyncScheduleKind
  {
    Manual,
    Every15Minutes,
    Every30Minutes,
    Every60Minutes,
    Every2Hours,
    Daily,
    AsItemsArrive,
  }
}
