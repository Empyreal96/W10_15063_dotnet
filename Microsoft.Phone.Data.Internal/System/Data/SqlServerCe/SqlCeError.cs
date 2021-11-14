// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeError
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeError
  {
    private int hResult;
    private string message;
    private string formattedMessage;
    private int nativeError;
    private string source;
    private int[] numericErrorParameters = new int[3];
    private string[] errorParameters = new string[3]
    {
      string.Empty,
      string.Empty,
      string.Empty
    };
    internal static Regex ParamInfoRegex = new Regex("(?<=[\\[])[^\\[\\]]+(?=[\\]][\\s]*$)", RegexOptions.IgnoreCase);

    static SqlCeError() => KillBitHelper.ThrowIfKillBitIsSet();

    internal SqlCeError(
      int hResult,
      string message,
      int nativeError,
      string source,
      int numericParameter1,
      int numericParameter2,
      int numericParameter3,
      string errorParameter1,
      string errorParameter2,
      string errorParameter3)
    {
      this.hResult = hResult;
      this.message = message;
      this.nativeError = nativeError;
      this.source = source;
      this.numericErrorParameters[0] = numericParameter1;
      this.numericErrorParameters[1] = numericParameter2;
      this.numericErrorParameters[2] = numericParameter3;
      this.errorParameters[0] = errorParameter1 != null ? errorParameter1 : string.Empty;
      this.errorParameters[1] = errorParameter2 != null ? errorParameter2 : string.Empty;
      if (errorParameter3 == null)
        this.errorParameters[2] = string.Empty;
      else
        this.errorParameters[2] = errorParameter3;
    }

    public int HResult => this.hResult;

    public string Message
    {
      get
      {
        if (this.formattedMessage != null)
          return this.formattedMessage;
        try
        {
          this.formattedMessage = this.FormatErrorMessage(this);
          return this.formattedMessage;
        }
        catch (Exception ex)
        {
          if (!ADP.IsCatchableExceptionType(ex))
          {
            throw;
          }
          else
          {
            Debug.Assert(false, "Unable to format the error message");
            return this.message != null ? this.message : string.Empty;
          }
        }
      }
    }

    public int NativeError => this.nativeError;

    public string Source => this.source == null ? string.Empty : this.source;

    public int[] NumericErrorParameters => this.numericErrorParameters;

    public string[] ErrorParameters => this.errorParameters;

    public override string ToString() => typeof (SqlCeError).ToString() + ": " + this.Message;

    internal static SqlCeError GetDefaultError(int hr) => new SqlCeError(hr, Res.GetString("ADP_NoErrorInfoPresent"), -1, string.Empty, 0, 0, 0, string.Empty, string.Empty, string.Empty);

    private string FormatErrorMessage(SqlCeError err)
    {
      string input = err.message;
      string[] strArray = new string[6]
      {
        "",
        "",
        "",
        "",
        "",
        ""
      };
      Match match;
      if ((match = SqlCeError.ParamInfoRegex.Match(input)).Success)
      {
        string str = match.Value;
        int startIndex = 0;
        for (int index = 0; index < 6; ++index)
        {
          int num = str.IndexOf(',', startIndex);
          if (-1 != num)
          {
            strArray[index] = str.Substring(startIndex, num - startIndex);
            startIndex = num + 1;
          }
          else
            strArray[index] = str.Substring(startIndex);
        }
        input = input.Substring(0, match.Index - 1).Trim();
      }
      Debug.Assert(3 == err.NumericErrorParameters.Length);
      Debug.Assert(3 == err.ErrorParameters.Length);
      StringBuilder stringBuilder = new StringBuilder();
      bool flag = true;
      for (int index = 0; index < 3; ++index)
      {
        int numericErrorParameter = err.NumericErrorParameters[index];
        if (strArray[index].Trim().Length > 0)
        {
          if (!flag)
            stringBuilder.Append(",");
          stringBuilder.Append(strArray[index]);
          stringBuilder.Append(" = ");
          stringBuilder.Append(numericErrorParameter);
          flag = false;
        }
        else if (numericErrorParameter != 0)
        {
          if (!flag)
            stringBuilder.Append(",");
          stringBuilder.Append(numericErrorParameter);
          flag = false;
        }
      }
      for (int index = 0; index < 3; ++index)
      {
        string path = err.ErrorParameters[index];
        if (path != null)
          path = path.Trim();
        switch (this.NativeError)
        {
          case 25028:
          case 25127:
          case 25140:
          case 28609:
          case 28610:
          case 28647:
            if (index == 0 && !string.IsNullOrEmpty(path))
            {
              path = Path.GetFileName(path);
              break;
            }
            break;
        }
        if (strArray[index + 3].Trim().Length > 0)
        {
          if (!flag)
            stringBuilder.Append(",");
          stringBuilder.Append(strArray[index + 3]);
          stringBuilder.Append(" = ");
          stringBuilder.Append(path);
          flag = false;
        }
        else if (path.Length > 0)
        {
          if (!flag)
            stringBuilder.Append(",");
          stringBuilder.Append(path);
          flag = false;
        }
      }
      if (stringBuilder.ToString().Length <= 0)
        return input;
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} [ {1} ]", (object) input, (object) stringBuilder.ToString());
    }
  }
}
