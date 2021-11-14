// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactIdsQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (PinnedContactIdsQueryResult))]
  [Guid(2107319634, 5497, 19932, 135, 31, 163, 10, 58, 234, 155, 161)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPinnedContactIdsQueryResult
  {
    IVector<string> ContactIds { get; }
  }
}
