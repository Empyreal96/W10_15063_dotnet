﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalogStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2710345366, 58971, 17972, 186, 33, 94, 99, 235, 114, 68, 167)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PackageCatalog))]
  internal interface IPackageCatalogStatics
  {
    PackageCatalog OpenForCurrentPackage();

    PackageCatalog OpenForCurrentUser();
  }
}
