// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(1132294477, 48512, 19056, 188, 80, 246, 231, 150, 80, 149, 117)]
  [ExclusiveTo(typeof (PackageStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageStatusChangedEventArgs
  {
    Package Package { get; }
  }
}
