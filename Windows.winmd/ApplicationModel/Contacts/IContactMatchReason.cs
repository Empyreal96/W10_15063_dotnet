// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactMatchReason
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactMatchReason))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163694340, 59352, 16702, 149, 244, 183, 92, 84, 199, 64, 119)]
  internal interface IContactMatchReason
  {
    ContactMatchReasonKind Field { get; }

    IVectorView<TextSegment> Segments { get; }

    string Text { get; }
  }
}
