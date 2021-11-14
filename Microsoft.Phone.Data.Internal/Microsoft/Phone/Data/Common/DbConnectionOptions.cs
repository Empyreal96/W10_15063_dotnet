// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbConnectionOptions
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.Phone.Data.Common
{
  internal class DbConnectionOptions
  {
    private const RegexOptions StandardRegexOption = RegexOptions.None;
    private static readonly Regex ConnectionStringQuoteValueRegex = new Regex("^[^\"'=;\\s\\p{Cc}]*$", RegexOptions.None);
    private static readonly Regex ConnectionStringQuoteOdbcValueRegex = new Regex("^\\{([^\\}\0]|\\}\\})*\\}$", RegexOptions.ExplicitCapture);
    private static readonly Regex ConnectionStringValidValueRegex = new Regex("^[^\0]*$", RegexOptions.None);
    private const string ConnectionStringValidKeyPattern = "^(?![;\\s])[^\\p{Cc}]+(?<!\\s)$";
    private const string ConnectionStringQuoteValuePattern = "^[^\"'=;\\s\\p{Cc}]*$";
    private const string ConnectionStringQuoteOdbcValuePattern = "^\\{([^\\}\0]|\\}\\})*\\}$";
    private const string ConnectionStringValidValuePattern = "^[^\0]*$";
    private const string ConnectionStringPattern = "([\\s;]*(?![\\s;])(?<key>([^=\\s\\p{Cc}]|\\s+[^=\\s\\p{Cc}]|\\s+==|==)+)\\s*=(?!=)\\s*(?<value>(\"([^\"\0]|\"\")*\")|('([^'\0]|'')*')|((?![\"'\\s])([^;\\s\\p{Cc}]|\\s+[^;\\s\\p{Cc}])*(?<![\"'])))(\\s*)(;|\0|$))*[\\s;\0]*";
    private const string ConnectionStringPatternOdbc = "([\\s;]*(?![\\s;])(?<key>([^=\\s\\p{Cc}]|\\s+[^=\\s\\p{Cc}])+)\\s*=\\s*(?<value>(\\{([^\\}\0]|\\}\\})*\\})|((?![\\{\\s])([^;\\s\\p{Cc}]|\\s+[^;\\s\\p{Cc}])*(?<![\\}])))(\\s*)(;|\0|$))*[\\s;\0]*";
    private static readonly Regex ConnectionStringRegex = new Regex("([\\s;]*(?![\\s;])(?<key>([^=\\s\\p{Cc}]|\\s+[^=\\s\\p{Cc}]|\\s+==|==)+)\\s*=(?!=)\\s*(?<value>(\"([^\"\0]|\"\")*\")|('([^'\0]|'')*')|((?![\"'\\s])([^;\\s\\p{Cc}]|\\s+[^;\\s\\p{Cc}])*(?<![\"'])))(\\s*)(;|\0|$))*[\\s;\0]*", (RegexOptions) 12);
    private static readonly Regex ConnectionStringRegexOdbc = new Regex("([\\s;]*(?![\\s;])(?<key>([^=\\s\\p{Cc}]|\\s+[^=\\s\\p{Cc}])+)\\s*=\\s*(?<value>(\\{([^\\}\0]|\\}\\})*\\})|((?![\\{\\s])([^;\\s\\p{Cc}]|\\s+[^;\\s\\p{Cc}])*(?<![\\}])))(\\s*)(;|\0|$))*[\\s;\0]*", (RegexOptions) 12);
    internal const string DataDirectory = "|datadirectory|";
    private static readonly Regex ConnectionStringValidKeyRegex = new Regex("^(?![;\\s])[^\\p{Cc}]+(?<!\\s)$", RegexOptions.None);
    private readonly string _usersConnectionString;
    private readonly Microsoft.Phone.Data.Workaround.Hashtable _parsetable;
    internal readonly NameValuePair KeyChain;
    internal readonly bool HasPasswordKeyword;
    internal readonly bool UseOdbcRules;

    public DbConnectionOptions(string connectionString, Microsoft.Phone.Data.Workaround.Hashtable synonyms, bool useOdbcRules)
    {
      this.UseOdbcRules = useOdbcRules;
      this._parsetable = new Microsoft.Phone.Data.Workaround.Hashtable();
      this._usersConnectionString = connectionString != null ? connectionString : "";
      if (0 >= this._usersConnectionString.Length)
        return;
      this.KeyChain = DbConnectionOptions.ParseInternal(this._parsetable, this._usersConnectionString, true, synonyms, this.UseOdbcRules);
      this.HasPasswordKeyword = this._parsetable.ContainsKey((object) "password") || this._parsetable.ContainsKey((object) "pwd");
    }

    internal static void AppendKeyValuePairBuilder(
      StringBuilder builder,
      string keyName,
      string keyValue,
      bool useOdbcRules)
    {
      ADP.CheckArgumentNull((object) builder, nameof (builder));
      ADP.CheckArgumentLength(keyName, nameof (keyName));
      if (keyName == null || !DbConnectionOptions.ConnectionStringValidKeyRegex.IsMatch(keyName))
        throw ADP.InvalidKeyname(keyName);
      if (keyValue != null && !DbConnectionOptions.IsValueValidInternal(keyValue))
        throw ADP.InvalidValue(keyName);
      if (0 < builder.Length)
      {
        StringBuilder stringBuilder = builder;
        if (';' != stringBuilder[stringBuilder.Length - 1])
          builder.Append(";");
      }
      if (useOdbcRules)
        builder.Append(keyName);
      else
        builder.Append(keyName.Replace("=", "=="));
      builder.Append("=");
      if (keyValue == null)
        return;
      if (useOdbcRules)
      {
        if (0 < keyValue.Length && ('{' == keyValue[0] || 0 <= keyValue.IndexOf(';') || string.Compare("Driver", keyName, StringComparison.OrdinalIgnoreCase) == 0) && !DbConnectionOptions.ConnectionStringQuoteOdbcValueRegex.IsMatch(keyValue))
          builder.Append('{').Append(keyValue.Replace("}", "}}")).Append('}');
        else
          builder.Append(keyValue);
      }
      else if (DbConnectionOptions.ConnectionStringQuoteValueRegex.IsMatch(keyValue))
        builder.Append(keyValue);
      else if (-1 != keyValue.IndexOf('"') && -1 == keyValue.IndexOf('\''))
      {
        builder.Append('\'');
        builder.Append(keyValue);
        builder.Append('\'');
      }
      else
      {
        builder.Append('"');
        builder.Append(keyValue.Replace("\"", "\"\""));
        builder.Append('"');
      }
    }

    private static string GetKeyName(StringBuilder buffer)
    {
      int length = buffer.Length;
      while (0 < length && char.IsWhiteSpace(buffer[length - 1]))
        --length;
      return buffer.ToString(0, length).ToLower(CultureInfo.InvariantCulture);
    }

    private static string GetKeyValue(StringBuilder buffer, bool trimWhitespace)
    {
      int length = buffer.Length;
      int num = 0;
      if (trimWhitespace)
      {
        while (num < length && char.IsWhiteSpace(buffer[num]))
          ++num;
        while (0 < length && char.IsWhiteSpace(buffer[length - 1]))
          --length;
      }
      return buffer.ToString(num, length - num);
    }

    internal static int GetKeyValuePair(
      string connectionString,
      int currentPosition,
      StringBuilder buffer,
      bool useOdbcRules,
      out string keyname,
      out string keyvalue)
    {
      int index = currentPosition;
      buffer.Length = 0;
      keyname = (string) null;
      keyvalue = (string) null;
      char minValue = char.MinValue;
      DbConnectionOptions.ParserState parserState = DbConnectionOptions.ParserState.NothingYet;
      for (int length = connectionString.Length; currentPosition < length; ++currentPosition)
      {
        minValue = connectionString[currentPosition];
        switch (parserState)
        {
          case DbConnectionOptions.ParserState.NothingYet:
            if (';' != minValue && !char.IsWhiteSpace(minValue))
            {
              if (minValue == char.MinValue)
              {
                parserState = DbConnectionOptions.ParserState.NullTermination;
                continue;
              }
              if (char.IsControl(minValue))
                throw ADP.ConnectionStringSyntax(index);
              index = currentPosition;
              if ('=' != minValue)
              {
                parserState = DbConnectionOptions.ParserState.Key;
                break;
              }
              parserState = DbConnectionOptions.ParserState.KeyEqual;
              continue;
            }
            continue;
          case DbConnectionOptions.ParserState.Key:
            if ('=' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.KeyEqual;
              continue;
            }
            if (!char.IsWhiteSpace(minValue) && char.IsControl(minValue))
              throw ADP.ConnectionStringSyntax(index);
            break;
          case DbConnectionOptions.ParserState.KeyEqual:
            if (!useOdbcRules && '=' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.Key;
              break;
            }
            keyname = DbConnectionOptions.GetKeyName(buffer);
            if (ADP.IsEmpty(keyname))
              throw ADP.ConnectionStringSyntax(index);
            buffer.Length = 0;
            parserState = DbConnectionOptions.ParserState.KeyEnd;
            goto case DbConnectionOptions.ParserState.KeyEnd;
          case DbConnectionOptions.ParserState.KeyEnd:
            if (!char.IsWhiteSpace(minValue))
            {
              if (useOdbcRules)
              {
                if ('{' == minValue)
                {
                  parserState = DbConnectionOptions.ParserState.BraceQuoteValue;
                  break;
                }
              }
              else
              {
                if ('\'' == minValue)
                {
                  parserState = DbConnectionOptions.ParserState.SingleQuoteValue;
                  continue;
                }
                if ('"' == minValue)
                {
                  parserState = DbConnectionOptions.ParserState.DoubleQuoteValue;
                  continue;
                }
              }
              if (';' != minValue && minValue != char.MinValue)
              {
                if (char.IsControl(minValue))
                  throw ADP.ConnectionStringSyntax(index);
                parserState = DbConnectionOptions.ParserState.UnquotedValue;
                break;
              }
              goto label_64;
            }
            else
              continue;
          case DbConnectionOptions.ParserState.UnquotedValue:
            if (char.IsWhiteSpace(minValue) || !char.IsControl(minValue) && ';' != minValue)
              break;
            goto label_64;
          case DbConnectionOptions.ParserState.DoubleQuoteValue:
            if ('"' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.DoubleQuoteValueQuote;
              continue;
            }
            if (minValue == char.MinValue)
              throw ADP.ConnectionStringSyntax(index);
            break;
          case DbConnectionOptions.ParserState.DoubleQuoteValueQuote:
            if ('"' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.DoubleQuoteValue;
              break;
            }
            keyvalue = DbConnectionOptions.GetKeyValue(buffer, false);
            parserState = DbConnectionOptions.ParserState.QuotedValueEnd;
            goto case DbConnectionOptions.ParserState.QuotedValueEnd;
          case DbConnectionOptions.ParserState.SingleQuoteValue:
            if ('\'' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.SingleQuoteValueQuote;
              continue;
            }
            if (minValue == char.MinValue)
              throw ADP.ConnectionStringSyntax(index);
            break;
          case DbConnectionOptions.ParserState.SingleQuoteValueQuote:
            if ('\'' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.SingleQuoteValue;
              break;
            }
            keyvalue = DbConnectionOptions.GetKeyValue(buffer, false);
            parserState = DbConnectionOptions.ParserState.QuotedValueEnd;
            goto case DbConnectionOptions.ParserState.QuotedValueEnd;
          case DbConnectionOptions.ParserState.BraceQuoteValue:
            if ('}' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.BraceQuoteValueQuote;
              break;
            }
            if (minValue == char.MinValue)
              throw ADP.ConnectionStringSyntax(index);
            break;
          case DbConnectionOptions.ParserState.BraceQuoteValueQuote:
            if ('}' == minValue)
            {
              parserState = DbConnectionOptions.ParserState.BraceQuoteValue;
              break;
            }
            keyvalue = DbConnectionOptions.GetKeyValue(buffer, false);
            parserState = DbConnectionOptions.ParserState.QuotedValueEnd;
            goto case DbConnectionOptions.ParserState.QuotedValueEnd;
          case DbConnectionOptions.ParserState.QuotedValueEnd:
            if (!char.IsWhiteSpace(minValue))
            {
              if (';' != minValue)
              {
                if (minValue != char.MinValue)
                  throw ADP.ConnectionStringSyntax(index);
                parserState = DbConnectionOptions.ParserState.NullTermination;
                continue;
              }
              goto label_64;
            }
            else
              continue;
          case DbConnectionOptions.ParserState.NullTermination:
            if (minValue != char.MinValue && !char.IsWhiteSpace(minValue))
              throw ADP.ConnectionStringSyntax(currentPosition);
            continue;
          default:
            throw ADP.InternalError(ADP.InternalErrorCode.InvalidParserState1);
        }
        buffer.Append(minValue);
      }
label_64:
      switch (parserState)
      {
        case DbConnectionOptions.ParserState.NothingYet:
        case DbConnectionOptions.ParserState.KeyEnd:
        case DbConnectionOptions.ParserState.NullTermination:
          if (';' == minValue && currentPosition < connectionString.Length)
            ++currentPosition;
          return currentPosition;
        case DbConnectionOptions.ParserState.Key:
        case DbConnectionOptions.ParserState.DoubleQuoteValue:
        case DbConnectionOptions.ParserState.SingleQuoteValue:
        case DbConnectionOptions.ParserState.BraceQuoteValue:
          throw ADP.ConnectionStringSyntax(index);
        case DbConnectionOptions.ParserState.KeyEqual:
          keyname = DbConnectionOptions.GetKeyName(buffer);
          if (ADP.IsEmpty(keyname))
            throw ADP.ConnectionStringSyntax(index);
          goto case DbConnectionOptions.ParserState.NothingYet;
        case DbConnectionOptions.ParserState.UnquotedValue:
          keyvalue = DbConnectionOptions.GetKeyValue(buffer, true);
          string str = keyvalue;
          char ch = str[str.Length - 1];
          if (!useOdbcRules && ('\'' == ch || '"' == ch))
            throw ADP.ConnectionStringSyntax(index);
          goto case DbConnectionOptions.ParserState.NothingYet;
        case DbConnectionOptions.ParserState.DoubleQuoteValueQuote:
        case DbConnectionOptions.ParserState.SingleQuoteValueQuote:
        case DbConnectionOptions.ParserState.BraceQuoteValueQuote:
        case DbConnectionOptions.ParserState.QuotedValueEnd:
          keyvalue = DbConnectionOptions.GetKeyValue(buffer, false);
          goto case DbConnectionOptions.ParserState.NothingYet;
        default:
          throw ADP.InternalError(ADP.InternalErrorCode.InvalidParserState2);
      }
    }

    private static bool IsValueValidInternal(string keyvalue)
    {
      if (keyvalue == null)
        return true;
      bool flag = DbConnectionOptions.ConnectionStringValidValueRegex.IsMatch(keyvalue);
      Debug.Assert(-1 == keyvalue.IndexOf(char.MinValue) == flag, "IsValueValid mismatch with regex");
      return -1 == keyvalue.IndexOf(char.MinValue);
    }

    private static bool IsKeyNameValid(string keyname)
    {
      if (keyname == null)
        return false;
      bool flag = DbConnectionOptions.ConnectionStringValidKeyRegex.IsMatch(keyname);
      Debug.Assert((0 >= keyname.Length || ';' == keyname[0] || char.IsWhiteSpace(keyname[0]) ? 0 : (-1 == keyname.IndexOf(char.MinValue) ? 1 : 0)) == (flag ? 1 : 0), "IsValueValid mismatch with regex");
      return 0 < keyname.Length && ';' != keyname[0] && !char.IsWhiteSpace(keyname[0]) && -1 == keyname.IndexOf(char.MinValue);
    }

    private static void ParseComparision(
      Microsoft.Phone.Data.Workaround.Hashtable parsetable,
      string connectionString,
      Microsoft.Phone.Data.Workaround.Hashtable synonyms,
      bool firstKey,
      Exception e)
    {
      try
      {
        foreach (DictionaryEntry dictionaryEntry in DbConnectionOptions.SplitConnectionString(connectionString, synonyms, firstKey))
        {
          string key = (string) dictionaryEntry.Key;
          string str1 = (string) dictionaryEntry.Value;
          string str2 = (string) parsetable[(object) key];
          Debug.Assert(parsetable.Contains((object) key), "ParseInternal code vs. regex mismatch keyname <" + key + ">");
          Debug.Assert((str1 == str2 ? 1 : 0) != 0, "ParseInternal code vs. regex mismatch keyvalue <" + str1 + "> <" + str2 + ">");
        }
      }
      catch (ArgumentException ex)
      {
        if (e != null)
        {
          string message1 = e.Message;
          string message2 = ex.Message;
          if (!message1.StartsWith("Keyword not supported:", StringComparison.Ordinal) || !message2.StartsWith("Format of the initialization string", StringComparison.Ordinal))
            Debug.Assert((message1 == message2 ? 1 : 0) != 0, "ParseInternal code vs regex message mismatch: <" + message1 + "> <" + message2 + ">");
        }
        else
          Debug.Assert(false, "ParseInternal code vs regex throw mismatch " + ex.Message);
        e = (Exception) null;
      }
      if (e == null)
        return;
      Debug.Assert(false, "ParseInternal code threw exception vs regex mismatch");
    }

    private static Microsoft.Phone.Data.Workaround.Hashtable SplitConnectionString(
      string connectionString,
      Microsoft.Phone.Data.Workaround.Hashtable synonyms,
      bool firstKey)
    {
      Microsoft.Phone.Data.Workaround.Hashtable hashtable = new Microsoft.Phone.Data.Workaround.Hashtable();
      Regex regex = firstKey ? DbConnectionOptions.ConnectionStringRegexOdbc : DbConnectionOptions.ConnectionStringRegex;
      Debug.Assert(1 == regex.GroupNumberFromName("key"), "wrong key index");
      Debug.Assert(2 == regex.GroupNumberFromName("value"), "wrong value index");
      if (connectionString != null)
      {
        Match match = regex.Match(connectionString);
        if (!match.Success || match.Length != connectionString.Length)
          throw ADP.ConnectionStringSyntax(match.Length);
        int num = 0;
        CaptureCollection captures = match.Groups[2].Captures;
        foreach (Capture capture in match.Groups[1].Captures)
        {
          string lower = (firstKey ? capture.Value : capture.Value.Replace("==", "=")).ToLower(CultureInfo.InvariantCulture);
          string str = captures[num++].Value;
          if (0 < str.Length)
          {
            if (!firstKey)
            {
              switch (str[0])
              {
                case '"':
                  str = str.Substring(1, str.Length - 2).Replace("\"\"", "\"");
                  break;
                case '\'':
                  str = str.Substring(1, str.Length - 2).Replace("''", "'");
                  break;
              }
            }
          }
          else
            str = (string) null;
          string keyname = synonyms != null ? (string) synonyms[(object) lower] : lower;
          if (!DbConnectionOptions.IsKeyNameValid(keyname))
            throw ADP.KeywordNotSupported(lower);
          if (!firstKey || !hashtable.ContainsKey((object) keyname))
            hashtable[(object) keyname] = (object) str;
        }
      }
      return hashtable;
    }

    private static NameValuePair ParseInternal(
      Microsoft.Phone.Data.Workaround.Hashtable parsetable,
      string connectionString,
      bool buildChain,
      Microsoft.Phone.Data.Workaround.Hashtable synonyms,
      bool firstKey)
    {
      Debug.Assert(connectionString != null, "null connectionstring");
      StringBuilder buffer = new StringBuilder();
      NameValuePair nameValuePair1 = (NameValuePair) null;
      NameValuePair nameValuePair2 = (NameValuePair) null;
      try
      {
        int num = 0;
        int length = connectionString.Length;
        while (num < length)
        {
          int currentPosition = num;
          string keyname;
          string keyvalue;
          num = DbConnectionOptions.GetKeyValuePair(connectionString, currentPosition, buffer, firstKey, out keyname, out keyvalue);
          if (!ADP.IsEmpty(keyname))
          {
            Debug.Assert(DbConnectionOptions.IsKeyNameValid(keyname), "ParseFailure, invalid keyname");
            Debug.Assert(DbConnectionOptions.IsValueValidInternal(keyvalue), "parse failure, invalid keyvalue");
            string str = synonyms != null ? (string) synonyms[(object) keyname] : keyname;
            if (!DbConnectionOptions.IsKeyNameValid(str))
              throw ADP.KeywordNotSupported(keyname);
            if (!firstKey || !parsetable.Contains((object) str))
              parsetable[(object) str] = (object) keyvalue;
            if (nameValuePair1 != null)
              nameValuePair1 = nameValuePair1.Next = new NameValuePair(str, keyvalue, num - currentPosition);
            else if (buildChain)
              nameValuePair2 = nameValuePair1 = new NameValuePair(str, keyvalue, num - currentPosition);
          }
          else
            break;
        }
      }
      catch (ArgumentException ex)
      {
        DbConnectionOptions.ParseComparision(parsetable, connectionString, synonyms, firstKey, (Exception) ex);
        throw;
      }
      DbConnectionOptions.ParseComparision(parsetable, connectionString, synonyms, firstKey, (Exception) null);
      return nameValuePair2;
    }

    internal static void ValidateKeyValuePair(string keyword, string value)
    {
      if (keyword == null || !DbConnectionOptions.ConnectionStringValidKeyRegex.IsMatch(keyword))
        throw ADP.InvalidKeyname(keyword);
      if (value != null && !DbConnectionOptions.ConnectionStringValidValueRegex.IsMatch(value))
        throw ADP.InvalidValue(keyword);
    }

    private static class KEY
    {
      internal const string Integrated_Security = "integrated security";
      internal const string Password = "password";
      internal const string Persist_Security_Info = "persist security info";
      internal const string User_ID = "user id";
    }

    private static class SYNONYM
    {
      internal const string Pwd = "pwd";
      internal const string UID = "uid";
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
      SingleQuoteValue = 8,
      SingleQuoteValueQuote = 9,
      BraceQuoteValue = 10, // 0x0000000A
      BraceQuoteValueQuote = 11, // 0x0000000B
      QuotedValueEnd = 12, // 0x0000000C
      NullTermination = 13, // 0x0000000D
    }
  }
}
