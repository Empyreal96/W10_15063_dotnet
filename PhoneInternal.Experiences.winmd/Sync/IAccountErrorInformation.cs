// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccountErrorInformation
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [ExclusiveTo(typeof (AccountErrorInformation))]
  [Version(100859904)]
  [Guid(860511644, 32806, 18405, 169, 246, 239, 199, 80, 14, 99, 21)]
  internal interface IAccountErrorInformation
  {
    SyncErrorType SyncErrorType { get; }

    ServerType ServerType { get; }
  }
}
