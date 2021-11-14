// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [Guid(2791387062, 30344, 19150, 149, 251, 53, 149, 56, 231, 170, 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackage2
  {
    string DisplayName { get; }

    string PublisherDisplayName { get; }

    string Description { get; }

    Uri Logo { get; }

    bool IsResourcePackage { get; }

    bool IsBundle { get; }

    bool IsDevelopmentMode { get; }
  }
}
