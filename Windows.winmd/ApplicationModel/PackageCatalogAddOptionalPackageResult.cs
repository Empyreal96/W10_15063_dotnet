// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalogAddOptionalPackageResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PackageCatalogAddOptionalPackageResult : 
    IPackageCatalogAddOptionalPackageResult
  {
    public extern Package Package { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
