// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.ConStringUtil
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Data.SqlServerCe
{
  internal sealed class ConStringUtil
  {
    public const string EngineDefault = "Engine Default";
    public const string PlatformDefault = "Platform Default";
    public const string ReadOnly = "Read Only";
    public const string ReadWrite = "Read Write";
    public const string Exclusive = "Exclusive";
    public const string SharedRead = "Shared Read";
    private const string DataDirectoryMacro = "|DataDirectory|";
    private const string DataDirectory = "DataDirectory";
    private static readonly Hashtable _encryptionModeMapping = new Hashtable(2)
    {
      [(object) "Platform Default"] = (object) 1,
      [(object) "Engine Default"] = (object) 2
    };
    private static readonly Hashtable _connectionSynonymMapping = KeywordMapper.KeywordSynonymsMapping;
    private const int _encryptionModeOptions = 2;
    private const char _equalSign = '=';
    private const char _semiColon = ';';
    private const char _singleQuote = '\'';
    private const char _doubleQuote = '"';
    private const char _space = ' ';
    private const char _tab = '\t';
    private const char _backslash = '\\';

    public static int MapEncryptionMode(string value) => value != null && ConStringUtil._encryptionModeMapping.ContainsKey((object) value) ? (int) ConStringUtil._encryptionModeMapping[(object) value] : 0;

    public static string RemoveKeyValuesFromString(string conString, string removeKey)
    {
      string conString1 = conString;
      int index = 0;
      int length = 0;
      ConStringUtil.SkipWhiteSpace(conString1, ref index);
      while (index < conString1.Length)
      {
        if (conString1[index] == ';')
        {
          ++index;
          length = index;
          ConStringUtil.SkipWhiteSpace(conString1, ref index);
        }
        else
        {
          int num = conString1.IndexOf('=', index);
          string lower = conString1.Substring(index, num - index).TrimEnd((char[]) null).ToLower(CultureInfo.InvariantCulture);
          index = num + 1;
          if (removeKey == (string) ConStringUtil._connectionSynonymMapping[(object) lower.ToLower(CultureInfo.InvariantCulture)])
          {
            string str1 = conString1.Substring(0, length);
            ConStringUtil.SkipValue(conString1, ref index);
            if (index < conString1.Length && conString1[index] == ';')
              ++index;
            string str2 = conString1.Substring(index);
            conString1 = str1 + str2;
            index = length;
            ConStringUtil.SkipWhiteSpace(conString1, ref index);
          }
          else
          {
            ConStringUtil.SkipValue(conString1, ref index);
            if (index < conString1.Length && conString1[index] == ';')
            {
              ++index;
              length = index;
              ConStringUtil.SkipWhiteSpace(conString1, ref index);
            }
          }
        }
      }
      return conString1;
    }

    public static Dictionary<string, string> ParseConnectionString(string connectionString)
    {
      Dictionary<string, string> values = new Dictionary<string, string>();
      switch (connectionString)
      {
        case "":
        case null:
          return values;
        default:
          ConStringUtil.ParseStringIntoTable(connectionString, values);
          goto case "";
      }
    }

    public static string ReplaceDataDirectory(string inputString) => inputString.Trim();

    public static string MapToOledbConnectionString(string conString)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string key = string.Empty;
      string empty = string.Empty;
      int currentPosition = 0;
      int vallength = 0;
      bool isempty = false;
      char[] charArray = conString.ToCharArray();
      char[] valuebuf = new char[conString.Length];
      while (currentPosition < conString.Length)
      {
        currentPosition = ConStringUtil.GetKeyValuePair(charArray, currentPosition, out key, valuebuf, out vallength, out isempty);
        if (!isempty)
        {
          string str = new string(valuebuf, 0, vallength);
          if (KeywordMapper.OledbAdoDotNetKeywordsMapping.ContainsKey(key))
            key = KeywordMapper.OledbAdoDotNetKeywordsMapping[key];
          stringBuilder.Append(key);
          stringBuilder.Append("=");
          stringBuilder.Append(str);
          stringBuilder.Append(";");
        }
      }
      return stringBuilder.ToString();
    }

    private static void SkipValue(string conString, ref int index)
    {
      ConStringUtil.SkipWhiteSpace(conString, ref index);
      if (index == conString.Length)
        return;
      char ch = conString[index];
      Debug.Assert(ch != ' ' && ch != '\t', "SqlConnection.SkipValue: first char was a space!");
      switch (ch)
      {
        case '"':
        case '\'':
          do
          {
            int num = conString.IndexOf(ch, index + 1);
            if (num == -1)
              Debug.Assert(num == -1, "SqlCeConnection.SkipValue: expecting ' or \" but not found");
            index = num + 1;
          }
          while (index < conString.Length && (int) conString[index] == (int) ch);
          ConStringUtil.SkipWhiteSpace(conString, ref index);
          break;
        case ';':
          break;
        default:
          index = conString.IndexOf(';', index + 1);
          if (index != -1)
            break;
          index = conString.Length;
          break;
      }
    }

    private static void SkipWhiteSpace(string conString, ref int index)
    {
      while (index < conString.Length)
      {
        switch (conString[index])
        {
          case '\t':
          case ' ':
            ++index;
            continue;
          default:
            return;
        }
      }
    }

    private static void ParseStringIntoTable(string conString, Dictionary<string, string> values)
    {
      int currentPosition = 0;
      int vallength = 0;
      bool isempty = false;
      string key = string.Empty;
      string empty = string.Empty;
      char[] charArray = conString.ToCharArray();
      char[] valuebuf = new char[conString.Length];
      while (currentPosition < conString.Length)
      {
        currentPosition = ConStringUtil.GetKeyValuePair(charArray, currentPosition, out key, valuebuf, out vallength, out isempty);
        if (!isempty)
        {
          string str = new string(valuebuf, 0, vallength);
          if (!ConStringUtil.InsertKeyValue(values, ref key, str))
            throw new ArgumentException(Res.GetString("SQL_InvalidConStringOption", (object) key));
        }
      }
    }

    private static Exception ConnectionStringSyntax(int index, char[] connectionString) => (Exception) new ArgumentException(Res.GetString("ADP_ConnectionStringSyntax", (object) index));

    private static int GetKeyValuePair(
      char[] connectionString,
      int currentPosition,
      out string key,
      char[] valuebuf,
      out int vallength,
      out bool isempty)
    {
      ConStringUtil.ParserState parserState = ConStringUtil.ParserState.NothingYet;
      int bufPosition = 0;
      int index = currentPosition;
      key = (string) null;
      vallength = -1;
      isempty = false;
      char minValue = char.MinValue;
      if (connectionString.Length >= int.MaxValue)
        throw new OverflowException();
      for (; currentPosition < connectionString.Length; ++currentPosition)
      {
        minValue = connectionString[currentPosition];
        switch (parserState)
        {
          case ConStringUtil.ParserState.NothingYet:
            if (';' != minValue && !char.IsWhiteSpace(minValue))
            {
              index = currentPosition;
              if (minValue == char.MinValue)
              {
                parserState = ConStringUtil.ParserState.NullTermination;
                continue;
              }
              if (char.IsControl(minValue))
                throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
              parserState = ConStringUtil.ParserState.Key;
              bufPosition = 0;
              break;
            }
            continue;
          case ConStringUtil.ParserState.Key:
            if ('=' == minValue)
            {
              parserState = ConStringUtil.ParserState.KeyEqual;
              continue;
            }
            if (!char.IsWhiteSpace(minValue) && char.IsControl(minValue))
              throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
            break;
          case ConStringUtil.ParserState.KeyEqual:
            if ('=' == minValue)
            {
              parserState = ConStringUtil.ParserState.Key;
              break;
            }
            key = ConStringUtil.GetKey(valuebuf, bufPosition);
            bufPosition = 0;
            parserState = ConStringUtil.ParserState.KeyEnd;
            goto case ConStringUtil.ParserState.KeyEnd;
          case ConStringUtil.ParserState.KeyEnd:
            if (!char.IsWhiteSpace(minValue))
            {
              if ('\'' == minValue)
              {
                parserState = ConStringUtil.ParserState.SingleQuoteValue;
                continue;
              }
              if ('"' == minValue)
              {
                parserState = ConStringUtil.ParserState.DoubleQuoteValue;
                continue;
              }
              if (';' != minValue && minValue != char.MinValue)
              {
                if (char.IsControl(minValue))
                  throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
                parserState = ConStringUtil.ParserState.UnquotedValue;
                break;
              }
              goto label_60;
            }
            else
              continue;
          case ConStringUtil.ParserState.UnquotedValue:
            if (char.IsWhiteSpace(minValue) || !char.IsControl(minValue) && ';' != minValue)
              break;
            goto label_60;
          case ConStringUtil.ParserState.DoubleQuoteValue:
            if ('"' == minValue)
            {
              parserState = ConStringUtil.ParserState.DoubleQuoteValueQuote;
              continue;
            }
            if (minValue == char.MinValue)
              throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
            break;
          case ConStringUtil.ParserState.DoubleQuoteValueQuote:
            if ('"' == minValue)
            {
              parserState = ConStringUtil.ParserState.DoubleQuoteValue;
              break;
            }
            parserState = ConStringUtil.ParserState.DoubleQuoteValueEnd;
            goto case ConStringUtil.ParserState.DoubleQuoteValueEnd;
          case ConStringUtil.ParserState.DoubleQuoteValueEnd:
            if (!char.IsWhiteSpace(minValue))
            {
              if (';' != minValue)
              {
                if (minValue != char.MinValue)
                  throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
                parserState = ConStringUtil.ParserState.NullTermination;
                continue;
              }
              goto label_60;
            }
            else
              continue;
          case ConStringUtil.ParserState.SingleQuoteValue:
            if ('\'' == minValue)
            {
              parserState = ConStringUtil.ParserState.SingleQuoteValueQuote;
              continue;
            }
            if (minValue == char.MinValue)
              throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
            break;
          case ConStringUtil.ParserState.SingleQuoteValueQuote:
            if ('\'' == minValue)
            {
              parserState = ConStringUtil.ParserState.SingleQuoteValue;
              break;
            }
            parserState = ConStringUtil.ParserState.SingleQuoteValueEnd;
            goto case ConStringUtil.ParserState.SingleQuoteValueEnd;
          case ConStringUtil.ParserState.SingleQuoteValueEnd:
            if (!char.IsWhiteSpace(minValue))
            {
              if (';' != minValue)
              {
                if (minValue != char.MinValue)
                  throw ConStringUtil.ConnectionStringSyntax(currentPosition, connectionString);
                parserState = ConStringUtil.ParserState.NullTermination;
                continue;
              }
              goto label_60;
            }
            else
              continue;
          case ConStringUtil.ParserState.NullTermination:
            if (minValue != char.MinValue && !char.IsWhiteSpace(minValue))
              throw ConStringUtil.ConnectionStringSyntax(index, connectionString);
            continue;
          default:
            Debug.Assert(false, "Undefined parser state");
            break;
        }
        valuebuf[bufPosition++] = minValue;
      }
      if (ConStringUtil.ParserState.KeyEqual == parserState)
      {
        key = ConStringUtil.GetKey(valuebuf, bufPosition);
        bufPosition = 0;
      }
      if (ConStringUtil.ParserState.Key == parserState || ConStringUtil.ParserState.DoubleQuoteValue == parserState || ConStringUtil.ParserState.SingleQuoteValue == parserState)
        throw ConStringUtil.ConnectionStringSyntax(index, connectionString);
label_60:
      if (ConStringUtil.ParserState.UnquotedValue == parserState)
      {
        bufPosition = ConStringUtil.TrimWhiteSpace(valuebuf, bufPosition);
        if ('\'' == valuebuf[bufPosition - 1] || '"' == valuebuf[bufPosition - 1])
          throw ConStringUtil.ConnectionStringSyntax(currentPosition - 1, connectionString);
      }
      else if (ConStringUtil.ParserState.KeyEqual != parserState && ConStringUtil.ParserState.KeyEnd != parserState)
        isempty = bufPosition == 0;
      if (';' == minValue && currentPosition < connectionString.Length)
        ++currentPosition;
      vallength = bufPosition;
      return currentPosition;
    }

    private static string GetKey(char[] valuebuf, int bufPosition)
    {
      bufPosition = ConStringUtil.TrimWhiteSpace(valuebuf, bufPosition);
      byte[] bytes = Encoding.Unicode.GetBytes(valuebuf, 0, bufPosition);
      return Encoding.Unicode.GetString(bytes, 0, bytes.Length).ToLower(CultureInfo.InvariantCulture);
    }

    private static int TrimWhiteSpace(char[] valuebuf, int bufPosition)
    {
      while (0 < bufPosition && char.IsWhiteSpace(valuebuf[bufPosition - 1]))
        --bufPosition;
      return bufPosition;
    }

    private static bool InsertKeyValue(
      Dictionary<string, string> values,
      ref string key,
      string value)
    {
      bool flag = true;
      if (string.Empty == value)
        value = (string) null;
      if (ConStringUtil._connectionSynonymMapping.ContainsKey((object) key))
      {
        key = (string) ConStringUtil._connectionSynonymMapping[(object) key];
        if (values.ContainsKey(key))
          values.Remove(key);
        values.Add(key, value);
      }
      else
        flag = false;
      return flag;
    }

    private enum ParserState
    {
      NothingYet = 1,
      Key = 2,
      KeyEqual = 3,
      KeyEnd = 4,
      UnquotedValue = 5,
      DoubleQuoteValue = 6,
      DoubleQuoteValueQuote = 7,
      DoubleQuoteValueEnd = 8,
      SingleQuoteValue = 9,
      SingleQuoteValueQuote = 10, // 0x0000000A
      SingleQuoteValueEnd = 11, // 0x0000000B
      NullTermination = 12, // 0x0000000C
    }
  }
}
