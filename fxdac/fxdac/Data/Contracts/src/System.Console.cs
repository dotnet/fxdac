[assembly:System.CLSCompliant(true)]
namespace System {

    public static partial class Console
    {
        public static System.IO.TextWriter Error { get { return default(System.IO.TextWriter); } }
        public static System.IO.TextReader In { get { return default(System.IO.TextReader); } }
        public static System.IO.TextWriter Out { get { return default(System.IO.TextWriter); } }
        public static System.IO.Stream OpenStandardError() { return default(System.IO.Stream); }
        public static System.IO.Stream OpenStandardError(int bufferSize) { return default(System.IO.Stream); }
        public static System.IO.Stream OpenStandardInput() { return default(System.IO.Stream); }
        public static System.IO.Stream OpenStandardInput(int bufferSize) { return default(System.IO.Stream); }
        public static System.IO.Stream OpenStandardOutput() { return default(System.IO.Stream); }
        public static System.IO.Stream OpenStandardOutput(int bufferSize) { return default(System.IO.Stream); }
        public static int Read() { return default(int); }
        public static string ReadLine() { return default(string); }
        public static void SetError(System.IO.TextWriter newError) { }
        public static void SetIn(System.IO.TextReader newIn) { }
        public static void SetOut(System.IO.TextWriter newOut) { }
        public static void Write(bool value) { }
        public static void Write(char value) { }
        public static void Write(char[] buffer) { }
        public static void Write(char[] buffer, int index, int count) { }
        public static void Write(decimal value) { }
        public static void Write(double value) { }
        public static void Write(int value) { }
        public static void Write(long value) { }
        public static void Write(object value) { }
        public static void Write(float value) { }
        public static void Write(string value) { }
        public static void Write(string format, object arg0) { }
        public static void Write(string format, object arg0, object arg1) { }
        public static void Write(string format, object arg0, object arg1, object arg2) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(string format, object arg0, object arg1, object arg2, object arg3, __arglist) { }
        public static void Write(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ulong value) { }
        public static void WriteLine() { }
        public static void WriteLine(bool value) { }
        public static void WriteLine(char value) { }
        public static void WriteLine(char[] buffer) { }
        public static void WriteLine(char[] buffer, int index, int count) { }
        public static void WriteLine(decimal value) { }
        public static void WriteLine(double value) { }
        public static void WriteLine(int value) { }
        public static void WriteLine(long value) { }
        public static void WriteLine(object value) { }
        public static void WriteLine(float value) { }
        public static void WriteLine(string value) { }
        public static void WriteLine(string format, object arg0) { }
        public static void WriteLine(string format, object arg0, object arg1) { }
        public static void WriteLine(string format, object arg0, object arg1, object arg2) { }
        [System.CLSCompliantAttribute(false)]
        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3, __arglist) { }
        public static void WriteLine(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public static void WriteLine(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void WriteLine(ulong value) { }
        public static event System.ConsoleCancelEventHandler CancelKeyPress { add { } remove { } }
        public static void Beep() { }
        public static void Beep(int frequency, int duration) { }
        public static void Clear() { }
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) { }
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, System.ConsoleColor sourceForeColor, System.ConsoleColor sourceBackColor) { }
        public static System.ConsoleKeyInfo ReadKey() { return default(System.ConsoleKeyInfo); }
        public static System.ConsoleKeyInfo ReadKey(bool intercept) { return default(System.ConsoleKeyInfo); }
        public static void ResetColor() { }
        public static void SetBufferSize(int width, int height) { }
        public static void SetCursorPosition(int left, int top) { }
        public static void SetWindowPosition(int left, int top) { }
        public static void SetWindowSize(int width, int height) { }
        public static System.ConsoleColor BackgroundColor { get { return default(System.ConsoleColor); } set { } }
        public static int BufferHeight { get { return default(int); } set { } }
        public static int BufferWidth { get { return default(int); } set { } }
        public static bool CapsLock { get { return default(bool); } }
        public static int CursorLeft { get { return default(int); } set { } }
        public static int CursorSize { get { return default(int); } set { } }
        public static int CursorTop { get { return default(int); } set { } }
        public static bool CursorVisible { get { return default(bool); } set { } }
        public static System.ConsoleColor ForegroundColor { get { return default(System.ConsoleColor); } set { } }
        public static System.Text.Encoding InputEncoding { get { return default(System.Text.Encoding); } set { } }
        public static bool IsErrorRedirected { get { return default(bool); } }
        public static bool IsInputRedirected { get { return default(bool); } }
        public static bool IsOutputRedirected { get { return default(bool); } }
        public static bool KeyAvailable { get { return default(bool); } }
        public static int LargestWindowHeight { get { return default(int); } }
        public static int LargestWindowWidth { get { return default(int); } }
        public static bool NumberLock { get { return default(bool); } }
        public static System.Text.Encoding OutputEncoding { get { return default(System.Text.Encoding); } set { } }
        public static string Title { get { return default(string); } set { } }
        public static bool TreatControlCAsInput { get { return default(bool); } set { } }
        public static int WindowHeight { get { return default(int); } set { } }
        public static int WindowLeft { get { return default(int); } set { } }
        public static int WindowTop { get { return default(int); } set { } }
        public static int WindowWidth { get { return default(int); } set { } }
    }

    public sealed partial class ConsoleCancelEventArgs : System.EventArgs
    {
        internal ConsoleCancelEventArgs() { }
        public bool Cancel { get { return default(bool); } set { } }
        public System.ConsoleSpecialKey SpecialKey { get { return default(System.ConsoleSpecialKey); } }
    }

    public delegate void ConsoleCancelEventHandler(object sender, System.ConsoleCancelEventArgs e);

    public enum ConsoleColor
    {
        Black = 0,
        Blue = 9,
        Cyan = 11,
        DarkBlue = 1,
        DarkCyan = 3,
        DarkGray = 8,
        DarkGreen = 2,
        DarkMagenta = 5,
        DarkRed = 4,
        DarkYellow = 6,
        Gray = 7,
        Green = 10,
        Magenta = 13,
        Red = 12,
        White = 15,
        Yellow = 14,
    }

    public enum ConsoleKey
    {
        A = 65,
        Add = 107,
        Applications = 93,
        Attention = 246,
        B = 66,
        Backspace = 8,
        BrowserBack = 166,
        BrowserFavorites = 171,
        BrowserForward = 167,
        BrowserHome = 172,
        BrowserRefresh = 168,
        BrowserSearch = 170,
        BrowserStop = 169,
        C = 67,
        Clear = 12,
        CrSel = 247,
        D = 68,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,
        Decimal = 110,
        Delete = 46,
        Divide = 111,
        DownArrow = 40,
        E = 69,
        End = 35,
        Enter = 13,
        EraseEndOfFile = 249,
        Escape = 27,
        Execute = 43,
        ExSel = 248,
        F = 70,
        F1 = 112,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        F13 = 124,
        F14 = 125,
        F15 = 126,
        F16 = 127,
        F17 = 128,
        F18 = 129,
        F19 = 130,
        F2 = 113,
        F20 = 131,
        F21 = 132,
        F22 = 133,
        F23 = 134,
        F24 = 135,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        G = 71,
        H = 72,
        Help = 47,
        Home = 36,
        I = 73,
        Insert = 45,
        J = 74,
        K = 75,
        L = 76,
        LaunchApp1 = 182,
        LaunchApp2 = 183,
        LaunchMail = 180,
        LaunchMediaSelect = 181,
        LeftArrow = 37,
        LeftWindows = 91,
        M = 77,
        MediaNext = 176,
        MediaPlay = 179,
        MediaPrevious = 177,
        MediaStop = 178,
        Multiply = 106,
        N = 78,
        NoName = 252,
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        O = 79,
        Oem1 = 186,
        Oem102 = 226,
        Oem2 = 191,
        Oem3 = 192,
        Oem4 = 219,
        Oem5 = 220,
        Oem6 = 221,
        Oem7 = 222,
        Oem8 = 223,
        OemClear = 254,
        OemComma = 188,
        OemMinus = 189,
        OemPeriod = 190,
        OemPlus = 187,
        P = 80,
        Pa1 = 253,
        Packet = 231,
        PageDown = 34,
        PageUp = 33,
        Pause = 19,
        Play = 250,
        Print = 42,
        PrintScreen = 44,
        Process = 229,
        Q = 81,
        R = 82,
        RightArrow = 39,
        RightWindows = 92,
        S = 83,
        Select = 41,
        Separator = 108,
        Sleep = 95,
        Spacebar = 32,
        Subtract = 109,
        T = 84,
        Tab = 9,
        U = 85,
        UpArrow = 38,
        V = 86,
        VolumeDown = 174,
        VolumeMute = 173,
        VolumeUp = 175,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        Zoom = 251,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ConsoleKeyInfo
    {
        public ConsoleKeyInfo(char keyChar, System.ConsoleKey key, bool shift, bool alt, bool control) { throw new System.NotImplementedException(); }
        public System.ConsoleKey Key { get { return default(System.ConsoleKey); } }
        public char KeyChar { get { return default(char); } }
        public System.ConsoleModifiers Modifiers { get { return default(System.ConsoleModifiers); } }
        public bool Equals(System.ConsoleKeyInfo obj) { return default(bool); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.ConsoleKeyInfo a, System.ConsoleKeyInfo b) { return default(bool); }
        public static bool operator !=(System.ConsoleKeyInfo a, System.ConsoleKeyInfo b) { return default(bool); }
    }

    [System.FlagsAttribute]
    public enum ConsoleModifiers
    {
        Alt = 1,
        Control = 4,
        Shift = 2,
    }

    public enum ConsoleSpecialKey
    {
        ControlBreak = 1,
        ControlC = 0,
    }
} // end of System
