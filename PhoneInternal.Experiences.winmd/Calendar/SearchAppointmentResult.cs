﻿// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Calendar.SearchAppointmentResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Calendar
{
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchAppointmentResult : ISearchAppointmentResult
  {
    [MethodImpl]
    public extern IAsyncOperation<IVector<Appointment>> GetNextMatchedAppointmentsAsync(
      uint count);
  }
}
