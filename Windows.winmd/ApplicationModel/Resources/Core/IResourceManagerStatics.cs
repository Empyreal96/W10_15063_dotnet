﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceManager))]
  [Guid(482409980, 27118, 20035, 153, 1, 71, 241, 38, 135, 186, 247)]
  internal interface IResourceManagerStatics
  {
    ResourceManager Current { get; }

    bool IsResourceReference(string resourceReference);
  }
}
