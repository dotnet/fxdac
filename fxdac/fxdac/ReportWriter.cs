using System;
using System.Collections.Generic;
using System.IO;

class ReportWriter : IDisposable
{
    TextWriter _writer;
    Stack<string> _listStack = new Stack<string>();
    public ReportWriter(string path)
    {
        _writer = new StreamWriter(path);
        _writer.WriteLine("<report>");
    }

    public void Dispose()
    {
        _writer.WriteLine("</report>");
        _writer.Dispose();
    }

    void WriteIndent()
    {
        if (_listStack.Count > 0) {
            _writer.Write(new string(' ', _listStack.Count * 2));
        }
    }
    public void WriteListStart(string listName, params object[] keyValuePairs)
    {
        if (keyValuePairs.Length / 2 * 2 != keyValuePairs.Length) throw new Exception("key not matches with value");
        _listStack.Push(listName);
        WriteIndent();
        _writer.Write("<{0}", listName);
        for(var i=0; i<keyValuePairs.Length; i+=2) {
            _writer.Write(" {0}=\"{1}\"", keyValuePairs[i], keyValuePairs[i + 1]);
        }
        _writer.WriteLine('>');
    }

    public void WriteListItem(string format, params object[] args)
    {
        WriteIndent();
        _writer.Write("  ");
        _writer.WriteLine("<item text=\"{0}\"/>", string.Format(format, args));
    }

    public void WriteListEnd()
    {
        WriteIndent();
        var name = _listStack.Pop();
        _writer.WriteLine("</{0}>", name);
    }
}

