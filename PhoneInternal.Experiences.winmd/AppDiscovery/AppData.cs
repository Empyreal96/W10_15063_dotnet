// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.AppData
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppData : IAppData
  {
    public extern Guid AppId { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string IconPath { [MethodImpl] get; }

    public extern string MediumTileImageUri { [MethodImpl] get; }

    public extern string LaunchUri { [MethodImpl] get; }

    public extern string Assembly { [MethodImpl] get; }

    public extern string AgentType { [MethodImpl] get; }

    public extern string AgentTaskId { [MethodImpl] get; }

    public extern string PackageFamilyName { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<bool> TestExtensionIDsAsync(ExtensionID extIdMask);

    [MethodImpl]
    public extern IAsyncOperation<bool> CheckCapabilityAsync(string capabilityName);

    [MethodImpl]
    public extern IAsyncOperation<IVector<IExtensionData>> GetExtensionsDataAsync(
      ExtensionID extIdMask);
  }
}
