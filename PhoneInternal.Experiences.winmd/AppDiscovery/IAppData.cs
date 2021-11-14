// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.IAppData
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [Version(100859904)]
  [Guid(3361920462, 10626, 16207, 136, 58, 213, 188, 69, 138, 29, 233)]
  public interface IAppData
  {
    Guid AppId { get; }

    string Title { get; }

    string IconPath { get; }

    string MediumTileImageUri { get; }

    string LaunchUri { get; }

    string Assembly { get; }

    string AgentType { get; }

    string AgentTaskId { get; }

    string PackageFamilyName { get; }

    IAsyncOperation<bool> TestExtensionIDsAsync(ExtensionID extIdMask);

    IAsyncOperation<bool> CheckCapabilityAsync(string capabilityName);

    IAsyncOperation<IVector<IExtensionData>> GetExtensionsDataAsync(
      ExtensionID extIdMask);
  }
}
