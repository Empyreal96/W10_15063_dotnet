// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.SqlTypes.SQLResource
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data.SqlTypes
{
  internal sealed class SQLResource
  {
    internal static readonly string NullString = Resources.SqlMisc_NullString;
    internal static readonly string MessageString = Resources.SqlMisc_MessageString;
    internal static readonly string ArithOverflowMessage = Resources.SqlMisc_ArithOverflowMessage;
    internal static readonly string DivideByZeroMessage = Resources.SqlMisc_DivideByZeroMessage;
    internal static readonly string NullValueMessage = Resources.SqlMisc_NullValueMessage;
    internal static readonly string TruncationMessage = Resources.SqlMisc_TruncationMessage;
    internal static readonly string DateTimeOverflowMessage = Resources.SqlMisc_DateTimeOverflowMessage;
    internal static readonly string ConcatDiffCollationMessage = Resources.SqlMisc_ConcatDiffCollationMessage;
    internal static readonly string CompareDiffCollationMessage = Resources.SqlMisc_CompareDiffCollationMessage;
    internal static readonly string InvalidFlagMessage = Resources.SqlMisc_InvalidFlagMessage;
    internal static readonly string NumeToDecOverflowMessage = Resources.SqlMisc_NumeToDecOverflowMessage;
    internal static readonly string ConversionOverflowMessage = Resources.SqlMisc_ConversionOverflowMessage;
    internal static readonly string InvalidDateTimeMessage = Resources.SqlMisc_InvalidDateTimeMessage;
    internal static readonly string TimeZoneSpecifiedMessage = Resources.SqlMisc_TimeZoneSpecifiedMessage;
    internal static readonly string InvalidArraySizeMessage = Resources.SqlMisc_InvalidArraySizeMessage;
    internal static readonly string InvalidPrecScaleMessage = Resources.SqlMisc_InvalidPrecScaleMessage;
    internal static readonly string FormatMessage = Resources.SqlMisc_FormatMessage;
    internal static readonly string NotFilledMessage = Resources.SqlMisc_NotFilledMessage;
    internal static readonly string ClosedXmlReaderMessage = Resources.SqlMisc_ClosedXmlReaderMessage;

    private SQLResource()
    {
    }

    internal static string InvalidOpStreamClosed(string method) => Res.GetString("SqlMisc_InvalidOpStreamClosed", (object) method);

    internal static string InvalidOpStreamNonWritable(string method) => Res.GetString("SqlMisc_InvalidOpStreamNonWritable", (object) method);

    internal static string InvalidOpStreamNonReadable(string method) => Res.GetString("SqlMisc_InvalidOpStreamNonReadable", (object) method);

    internal static string InvalidOpStreamNonSeekable(string method) => Res.GetString("SqlMisc_InvalidOpStreamNonSeekable", (object) method);
  }
}
