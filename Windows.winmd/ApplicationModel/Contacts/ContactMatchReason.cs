﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactMatchReason
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactMatchReason : IContactMatchReason
  {
    public extern ContactMatchReasonKind Field { [MethodImpl] get; }

    public extern IVectorView<TextSegment> Segments { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }
  }
}
