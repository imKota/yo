using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Specialized;
using System.IO;
using MyLists;
using RegExpr;
using DialogEnc;
using OptionsPage;
using About;
using Input;
using FileProp;
using Commons;
namespace Main
{
    public partial class TMainForm: Form
    {
    //@ Undeclared identifier(3): 'WM_NOTIFY'
    //@ Undeclared identifier(3): 'WM_DROPFILES'
        public bool Edited
        {
          get {
            return FEdited;
          }
          set {
            SetEdited(value);
          }
        }
        // Public declarations
        public TRichEditU Editor = null;
        public TRichEditU reAskText = null;
        public bool FEdited = false;
        public bool YoRunning = false;
        public DialogResult AskResult = null;
        public TextBox RedefiningKey = null;
        public TOpenDialogEx odxText = null;
        public TSaveDialogEx sdxText = null;
        public ImageList ToolBarImageList = null;
        public MenuItem Testing1 = null;
        public TMainForm()
        {
            InitializeComponent();
        }

        public void ReadDic_ParseWord(string s, ref string sYe, ref string sYo, ref int ToAsk)
        {
        }

        // TMainForm
        public void ReadDic()
        {
        }

        public void ReadRegExprDic()
        {
        }

        public void AddToStat(int Idx, string oldWord, string newWord, int DicWordIndex)
        {
        }

        public void ChangeLetter(int Idx, string oldWord, string newWord)
        {
        }

        public void CheckWord(int Idx, string cWord, ref bool ToCancel)
        {
        }

        public void CheckWordEx(int cLineN, int cPosN, string cNotWord, string cWord, char CurrentChar, ref bool ToCancel)
        {
        }

        public bool IsItAbbreviation(char c, int LineN, int PosN)
        {
            bool result = false;
            return result;
        }

        public bool IsItEllipsis(char c, int LineN, int PosN)
        {
            bool result = false;
            return result;
        }

        public void Yoficate_FindBinary(ref int p)
        {
        }

        public void Yoficate(int LineN0, int PosN0)
        {
        }

        public string FindReplacement(string WordYe, ref bool ToAsk, ref int Index, ref int WordToFocusN, ref bool Always)
        {
            string result = String.Empty;
            return result;
        }

        public string SelectWord(string cWord, int Idx, ref bool ToCancel, ref int DicWordIndex, ref int WordToFocusN, ref bool WrongYo)
        {
            string result = String.Empty;
            return result;
        }

        public void WMDropFiles(ref TWMDropFiles Msg)
        {
        }

        public void UpdateCursorPos()
        {
        }

        public void StatusInfo(string s)
        {
        }

        public void ShowStatus()
        {
        }

        public void WaitCursor()
        {
        }

        public void NormCursor()
        {
        }

        public void GoAndShowPosition(int i)
        {
        }

        public void FileLoad(string FileName, int FileType)
        {
        }

        public bool CanBeClosed()
        {
            bool result = false;
            return result;
        }

        public void SetEdited(bool Value)
        {
        }

        public bool DicExist()
        {
            bool result = false;
            return result;
        }

        public void WriteToRegExprLog(string s)
        {
        }

        public void ReadIni()
        {
        }

        public void WriteIni()
        {
        }

        public void SetWordWrap(bool Value)
        {
        }

        public void ReadParameters()
        {
        }

        public bool OpenText(string FileName, int FileType)
        {
            bool result = false;
            return result;
        }

        public void AddUndo(int p1, int p2, char c, Color Color, string OldWord, string NewWord)
        {
        }

        public void ClearUndo()
        {
        }

        public void ClearYYPos()
        {
        }

        public void EditorKeyPress(Object Sender, ref char Key)
        {
        }

        public void MakeUndo()
        {
        }

        public string UndoCaption()
        {
            string result = String.Empty;
            return result;
        }

        // ---
        public void DoYoficate(int LineN, int PosN)
        {
        }

        public void Yobegin1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Yopos1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void EditorChange(Object Sender)
        {
        }

        // Note: the original parameters are Object Sender, ref TCloseAction Action
        public void FormClose(System.Object Sender, System.EventArgs _e1)
        {
        }

        // Note: the original parameters are Object Sender, ref bool CanClose
        public void FormCloseQuery(System.Object Sender, System.ComponentModel.CancelEventArgs _e1)
        {
        }

        public void FindDialog1Find(Object Sender)
        {
        }

        public void Find1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void About1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Moreabout1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Close1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Undo1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void OpenDic1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void OpenRegExprDic1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void InitData()
        {
        }

        public void SetMenuItem(string ItemName, bool v)
        {
        }

        public void SetControls()
        {
        }

        public void EditorSelectionChange(Object Sender)
        {
        }

        public void RemoveMarkedLetters()
        {
        }

        public void Clearusersel1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void AddFileToList(string s, int p, int TextType)
        {
        }

        public void OpenTextInList(Object Sender)
        {
        }

        public void Clearfilelist1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void RememberFileNamesPos()
        {
        }

        public int GetFileNamesN(string s)
        {
            int result = 0;
            return result;
        }

        public int GetFileNamesPos(string s)
        {
            int result = 0;
            return result;
        }

        public void FormCreate(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void FormShow(Object Sender)
        {
        }

        public void LoadAll(Object Sender, ref bool Done)
        {
        }

        public void WaitStatus(string Msg)
        {
        }

        public void WaitStatusIf(string Msg)
        {
        }

        public void NoWaitStatus()
        {
        }

        public void NewEditorWinProc(ref Message Msg)
        {
        }

        public DialogResult WaitForAnswer()
        {
            DialogResult result = null;
            return result;
        }

        public void EnableAskControls(bool v)
        {
        }

        public void EnableMenu(bool v)
        {
        }

        public void bYeClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bYoClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bYeAllClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bYoAllClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bUndoClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bCancelClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public string FindContext(int i, ref int SelStart0, ref int SelLength0)
        {
            string result = String.Empty;
            return result;
        }

        public void SetAskParams(string w1, string w2, bool WrongYo, bool ReplacedYo, bool WrongYe, bool ToFocusFirst, string UndoCaption)
        {
        }

        public void InitAskParams()
        {
        }

        public void AlignAskPanel()
        {
        }

        public int DefineTextWidth(string s, Font Font)
        {
            int result = 0;
            return result;
        }

        public int FindTextLength(int i, Font Font)
        {
            int result = 0;
            return result;
        }

        public void SetAskPanelView(bool v)
        {
        }

        public void NewMainFormWinProc(ref Message Msg)
        {
        }

        public void RedefineKeyInit()
        {
        }

        public void SetButtonHotKey(int i, char c)
        {
        }

        public void RedefineKeyPress(Object Sender, ref char Key)
        {
        }

        public void RedefineKey(Object Sender)
        {
        }

        public void InitButtons()
        {
        }

        // Note: the original parameters are Object Sender, MouseButtons Button, Keys Shift, int X, int Y
        public void bYeMouseDown(System.Object Sender, System.Windows.Forms.MouseEventArgs _e1)
        {
        }

        // Note: the original parameters are Object Sender, MouseButtons Button, Keys Shift, int X, int Y
        public void bYoMouseDown(System.Object Sender, System.Windows.Forms.MouseEventArgs _e1)
        {
        }

        // Note: the original parameters are Object Sender, MouseButtons Button, Keys Shift, int X, int Y
        public void bYeAllMouseDown(System.Object Sender, System.Windows.Forms.MouseEventArgs _e1)
        {
        }

        // Note: the original parameters are Object Sender, MouseButtons Button, Keys Shift, int X, int Y
        public void bYoAllMouseDown(System.Object Sender, System.Windows.Forms.MouseEventArgs _e1)
        {
        }

        public void DisableButtons()
        {
        }

        public void EnableButtons()
        {
        }

        public string GetDicVersion(string s)
        {
            string result = String.Empty;
            return result;
        }

        public void Findreg1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Findagain1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void CalculateFileProp_CalcStat()
        {
        }

        public void CalculateFileProp()
        {
        }

        public void SaveFile()
        {
        }

        public bool SaveFileAs()
        {
            bool result = false;
            return result;
        }

        // --- автоматически сгенерированный процедуры ---
        public void Exit1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Open1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Saveas1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Cut1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Copy1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Paste1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Selectall1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Findyyfwd1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Findyyback1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Save1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Fileprop1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void FindDialog1Close(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void Options1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        // //////////////////////////////////////////
        // Далее идут эзотерические процедуры
        // кастомизации тулбара
        // //////////////////////////////////////////
        public void WMNotify(ref TWMNotify Message)
        {
        }

        public void SetToolBarSeparators()
        {
        }

        public MenuItem FindMenuItem(string ItemName)
        {
            MenuItem result = null;
            return result;
        }

        public TToolButtonX FindToolbarItem(string ItemName)
        {
            TToolButtonX result = null;
            return result;
        }

        public void FillToolBarImageList()
        {
        }

        public void CreateToolButtons()
        {
        }

        public void AddButtonToToolBar(string ItemName)
        {
        }

        public void RemoveMarked1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

    } // end TMainForm

    public class TDic
    {
        public List<string> Ye = null;
        public List<string> Yo = null;
        // словарь словоформ
        public TShortIntList WordsAsk = null;
        public TShortIntList WordsAnswer = null;
        public TShortIntList UserSel = null;
        public TIntegerList Ye2Ye = null;
        public TIntegerList Ye2Yo = null;
        public TIntegerList Yo2Ye = null;
        public TIntegerList Yo2Yo = null;
        // TDic
        public void Clear()
        {
        }

        //Constructor  Create()
        public TDic()
        {
        }
    } // end TDic

    public class TRegExprDic
    {
        public List<string> W0 = null;
        public List<string> W = null;
        public TRegExprList RE = null;
        public TIntegerList Was = null;
        // TRegExprDic
        //Constructor  Create()
        public TRegExprDic()
        {
        }
        public void Clear()
        {
        }

        public string AddWord_MakeValidRegExpr(string s)
        {
            string result;
            return result;
        }

        public bool AddWord(string s)
        {
            bool result = false;
            return result;
        }

    } // end TRegExprDic

    public class TRichEditU: TGsvUnicodeRichEdit
    {
        public string this[int Index]
        {
          get {
            return GetLine(Index);
          }
          set {
            PutLine(Index, value);
          }
        }
        public Color SelectionMarkColor
        {
          set {
            SetSelectionMarkColor(value);
          }
        }
        // RichEditU
        public void SetSelectionMarkColor(Color AColor)
        {
        }

        public string GetLine(int i)
        {
            string result = String.Empty;
            return result;
        }

        public void PutLine(int i, string s)
        {
        }

        public void GetLinePosition(int Idx, ref int LineN, ref int PosN)
        {
        }

        public void UpdateCursorPosition(StatusBar StatusBar, int PanelN)
        {
        }

        public void GoAndShowPosition(int i)
        {
        }

        public void LoadFromFile(string FileName, int TextType)
        {
        }

        public void SaveToFile(string FileName, int TextType)
        {
        }

        public void LinesAdd(string s)
        {
        }

        public void SetSelSize(int s)
        {
        }

        public void SetSelColor(Color c)
        {
        }

        public void SetSelBackColor(Color c)
        {
        }

        public Color GetSelColor()
        {
            Color result = null;
            return result;
        }

        public Color GetSelBackColor()
        {
            Color result = null;
            return result;
        }

        public void SetSelStyle(string s)
        {
        }

        public void SetSelName(string n)
        {
        }

        public int GetDefSize()
        {
            int result = 0;
            return result;
        }

        public void RestoreFocus(Object Sender)
        {
        }

    } // end TRichEditU

    public class TDialogEx: TDialogEnc
    {
        public int TypeOfText = 0;
        public TDialogEnc(Component AOwner) : base(AOwner)
        {
        }
        // Dialogs
        public void DoShow()
        {
        }

        public bool Execute()
        {
            bool result = false;
            return result;
        }

    } // end TDialogEx

    public class TOpenDialogEx: TDialogEx
    {
        //Constructor  Create( AOwner)
        public TOpenDialogEx(Component AOwner)
        {
        }
    } // end TOpenDialogEx

    public class TSaveDialogEx: TDialogEx
    {
        //Constructor  Create( AOwner)
        public TSaveDialogEx(Component AOwner)
        {
        }
        public bool Execute()
        {
            bool result = false;
            return result;
        }

    } // end TSaveDialogEx

    public class TToolButtonX: ToolBarButton
    {
        // TToolButtonX
        //Constructor  Create( AOwner)
        public TToolButtonX(Component AOwner)
        {
        }
    } // end TToolButtonX

    // текстовый файл
    // файл словаря
    // файл словаря рег. выражений
    // таблицы отката и замены
    // координаты окна
    // файл инициализации
    // для режима рег выражений
    // дял Юникода
    // длина блока (в словах) для распознавания UTF
    public class TLetterStat
    {
        public int A = 0;
        public int Changed = 0;
        public int NotChanged = 0;
        public void Clear()
        {
        }

    } // end TLetterStat

    public struct TFileProps
    {
        public string FileName;
        public string FileFormat;
    } // end TFileProps

    // список для сбора всех пунктов меню, которых нет на тулбаре
    public class TMenuItemsX: List<string>
    {
        // TMenuItemsX
        //Constructor  Create()
        public TMenuItemsX()
        {
        }
    } // end TMenuItemsX

    public delegate int TStrCompare(string s1, string s2);
}

namespace Main.Units
{
    public class Main
    {
        public static TMainForm MainForm = null;
        public static TDic Dic = null;
        public static string FirstDisorder = String.Empty;
        public static string WordNoYo = String.Empty;
        public static bool WasAsk = false;
        public static string WrongWord = String.Empty;
        public static bool FirstFind = false;
        public static int FoundLength = 0;
        public static string ProgramDirectory = null;
        public static string TextDirectory = null;
        public static string FullIniFileName = null;
        public static string TextFileName = null;
    // текстовый файл
        public static string RegExprTextFileName = null;
        public static string RegExprLogName = null;
        public static int TextFileType = 0;
        public static int TextFilePos = 0;
        public static string DicFileName = null;
    // файл словаря
        public static string RegExprDicFileName = null;
    // файл словаря рег. выражений
    // таблицы отката и замены
        public static TIntegerList UndoP1 = null;
        public static TIntegerList UndoP2 = null;
        public static TIntegerList UndoColor = null;
        public static string UndoLetter = String.Empty;
        public static List<string> UndoOldWord = null;
        public static List<string> UndoNewWord = null;
        public static bool ToMakeUndo = false;
    // координаты окна
        public static int WindowHeight = 0;
        public static int WindowWidth = 0;
        public static int WindowTop = 0;
        public static int WindowLeft = 0;
    // файл инициализации
        public static FileStream IniFile = null;
    // для режима рег выражений
        public static TRegExprDic RegExprDic = null;
        public static int WordsBufferLength2 = 0;
        public static TRegExpr tmpRegExpr = null;
        public static System.IO.Stream fRegExprlog = null;
        public static bool DicReloadRequest = false;
        public static bool RegExprDicReloadRequest = false;
        public static int FileNamesFirstItemN = 0;
        public static TIntegerList FileNamesPos = null;
        public static TIntegerList FileNamesTextType = null;
        public static Object FindEditor = null;
        public static DateTime RunTime0;
        public static int AskFormHeight = 0;
        public static TWndMethod EditorWinProc = null;
        public static Button[] Buttons = new Button[6 + 1];
        public static bool[] ButtonsEnabled = new bool[6 + 1];
        public static string[] ButtonHotKeys;
        public static int ButtonTag = 0;
        public static TRegExpr FindRegExpr = null;
        public static bool IsRegExpr = false;
        public static bool ToCheckAbbreviation = false;
        public static bool ToCheckEllipsis = false;
        public static bool UndoEnabled = false;
        public static bool FindAgain = false;
        public static bool FindNextWasPressed = false;
        public static bool WasFindReg = false;
    // дял Юникода
        public static TGsvUnicodeCharFormat UCF = null;
        public static byte UnicodeType = 0;
        public static int odxRTFIndex = 0;
        public static int sdxRTFIndex = 0;
        public static bool AskPanelFocusFirst = false;
        public static TIntegerList YYPos = null;
        public static bool UTF8Warning = false;
        public static int UTFLength = 0;
        public static TLetterStat CheckedLS = null;
        public static TLetterStat AskedLS = null;
        public static TLetterStat RELS = null;
        public static int NoRELS = 0;
        public static int WrongYoLS = 0;
        public static int CollectedYo = 0;
        public static TFileProps FileProps = null;
        public static TMenuItemsX MenuItemsX = null;
        // .$DEFINE Debug
        // to remove garbage after WordWrap on/off/on
        // .$APPTYPE CONSOLE
        // .$WARN UNSAFE_CODE OFF
        public const int Year = 2022;
        // Цвета
        public System.Drawing.Color clDicMark = System.Drawing.Color.Red;
        // цвет выделения в РС
        public Color clEditorWindow = System.Drawing.Color.White;
        public System.Drawing.Color clMarkWrong = System.Drawing.Color.Aqua;
        public const int clAskPanelActive = 0x00FFC0C0;
        public const int clAskPanelPassive = 0x00C0C0FF;
        public const int LinesBelow0 = 2;
        public const int WordsBufferLength = 5;
        public const bool FirstEditorChange = true;
        public const bool RegExprLog = false;
        public const int FileNamesInList = 0;
        public const int MaxFileNamesInList = 9;
        public const string VerStr = "Версия:";
        public const string msgAtt = "Внимание";
        public const string msgError = "Ошибка";
        public const string msgInfo = "Информация";
        public const string msgDisorderWord = "Порядок слов в словаре нарушен словом \"%s\"";
        public const string msgNoDic = "Не задан файл словаря";
        public const string msgFileNotFound = "Файл \"%s\" не найден";
        public const string msgBadString = "В строке словаре содержится неверная строка \"%s\"";
        public const string msgNoYo = "Слово \"%s\" из словаря не содержит буквы \"Ё\"";
        public const string msgNotRegExpr = "В словаре регулярных выражений содержится неверное выражение \"%s\"";
        public const string msgWasOldFormatRE = "Словарь регулярных выражений имеет старый формат.\rПрочитайте yo_plus.html, чтобы узнать, как переформатировать его.";
        public const string msgRewrite = "Файл %s существует. Переписать?";
        public const string msgToSave = "Файл был изменён. Сохранить изменения?";
        public const string msgClear = "Очистить список последних файлов?";
        public const string msgClearStat = "Обнулить статистку ёфикации?";
        public const string msgMayBeLost = "При сохранении файла в данном формате\rнекоторые символы могут быть потеряны.\r Продолжить?";
        public const string msgUTF16BE = "Файл имеет кодировку UTF-16 (big endian).\rК сожалению, программа не сможет его правильно прочитать.";
        public const string msgUTF8Warning = "Внимание! Файлы формата UTF-8 обычно обрабатываются программой очень медленно.\rВы уверены, что хотите загружать подобные файлы?";
        public const string msgNoMenuItems = "Эзотерическая ошибка #1: не найден пункт меню \"%s\"";
        public const string msgLoadDic = "Загрузка словаря";
        public const string msgLoadRegExprDic = "Загрузка словаря регулярных выражений";
        public const string NoMenuItemName = "";
        public const string StatusBarHint = "t=t1+t2 - полное число проверок (t1 - с заменой, t2 - без земены)\r\n" + "A=a1+a2 - число проверок слов с запросом (a1 - с заменой, a2 - без земены)\r\n" + "RE=r1+r2 - число применений СРВ (r1 - с заменой, r2 - без земены)\r\n" + "REQ - эффективность СРВ\r\n" + "E - число замен Ё на Е\r\n" + "T - время работы (сек)\r\n" + "S - скорость работы (замен/сек)";
        public const string ToolBarHint = "Дважды щёлкните здесь для настройки панели инструментов";
        public const string OldStatusBarText = "";
        public const string MySpaceChars = " \09\n\r ";
        // '0123456789'
        // + 'abcdefghijklmnopqrstuvwxyz'
        // + 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
        // +
        public const string MyWordChars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" + "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        // для AskPanel
        public const int mrYe = 0xFF01;
        public const int mrYo = 0xFF02;
        public const int mrYeAll = 0xFF03;
        public const int mrYoAll = 0xFF04;
        public const int mrUndo = 0xFF05;
        // для Save/Load
        public const int ttRTF = 0x01;
        public const int ttUTF8 = 0x02;
        public const int ttUTF16LE = 0x04;
        public const int ttUTF16BE = 0x08;
        // does not support !
        public const int ttUTFsgn = 0x10;
        public const int ttUTF16 = ttUTF16LE | ttUTF16BE;
        public const int ttUnicode = ttUTF8 | ttUTF16;
        public const ushort UnicodeSignatureUTF16LE = 0xFEFF;
        public const ushort UnicodeSignatureUTF16BE = 0xFFFE;
        public const ushort UnicodeSignatureUTF8a = 0xBBEF;
        public const byte UnicodeSignatureUTF8b = 0xBF;
        public const int AnsiIndex = 0;
        public const int UTF8Index = 1;
        public const int UTF16Index = 2;
        public const string DateFormat = "dd-mm-yyyy";
        public const int MaxToolButtonsQ = 50;
        // Общие функции
        // *** Общие функции
        public static void X(string s)
        {
        }

        public static bool IsEsc()
        {
            bool result = false;
            return result;
        }

        public static void ClearEsc()
        {
        }

        public static void Error(string Msg)
        {
        }

        public static void Info(string Msg)
        {
        }

        public static bool Warning(string Msg, bool DefaultYes)
        {
            bool result = false;
            return result;
        }

        public static ushort WarningX(string Msg, ushort DefaultAnswer)
        {
            ushort result = 0;
            return result;
        }

        public static bool CanBeRewriten(string FileName)
        {
            bool result = false;
            return result;
        }

        public static string RemoveProgramDir(string FileName)
        {
            string result = null;
            return result;
        }

        public static string AddProgramDir(string FileName)
        {
            string result = null;
            return result;
        }

        public static void SetCaptionAsterix(Form Form, bool Edited)
        {
        }

        // *** Функции анализа строк
        public static string DosFromWin(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static bool ContainsChar(string s, char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsComment(string s)
        {
            bool result = false;
            return result;
        }

        public static bool IsNumeric(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsUpper(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsLower(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsAlpha(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsAlphaQ(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsWord(string s)
        {
            bool result = false;
            return result;
        }

        public static bool IsWordQ(string s)
        {
            bool result = false;
            return result;
        }

        public static bool IsAnyUpperCase(string s)
        {
            bool result = false;
            return result;
        }

        public static int RegExprWordLen(string s)
        {
            int result = 0;
            return result;
        }

        public static string CopyCase(string w, string wCase)
        {
            string result = String.Empty;
            return result;
        }

        public static bool IsBlank(char c)
        {
            bool result = false;
            return result;
        }

        public static int PosFrom(string Substr, string S, int p0)
        {
            int result = 0;
            return result;
        }

        public static string LastChar(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static string DropLastChar(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static string LC(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static string ToYe(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static bool IsYo(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsYe(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsYeYo(char c)
        {
            bool result = false;
            return result;
        }

        public static bool IsYoIn(string s)
        {
            bool result = false;
            return result;
        }

        public static bool IsYeYoIn(string s)
        {
            bool result = false;
            return result;
        }

        public static bool IsYeYoIf(string s)
        {
            bool result = false;
            return result;
        }

        public static int ListCmpYe(List<string> List, int i1, int i2)
        {
            int result = 0;
            return result;
        }

        public static int ListCmpYeEx(List<string> List, int i1, int i2)
        {
            int result = 0;
            return result;
        }

        public static int Cmp(string s10, string s20)
        {
            int result = 0;
            return result;
        }

        public static int CmpYe(string s10, string s20)
        {
            int result = 0;
            return result;
        }

        public static int CmpYeEx(string s10, string s20)
        {
            int result = 0;
            return result;
        }

        public static int CmpYeExLC(string s10, string s20)
        {
            int result = 0;
            return result;
        }

        public static void Replace(ref string s, int i, ref string s1, ref string s2)
        {
        }

        public static string Cas(int i, int Mode)
        {
            string result = String.Empty;
            return result;
        }

        // *** функции TRichedit
        public static void GetLinePosInEditor(RichTextBox RE, int Idx, ref int LineN, ref int PosN)
        {
        }

        public static void GoAndShowPositionInEditor(RichTextBox RE, int i)
        {
        }

        public static void GoAndShowPositionInEditor(TRichEditU RE, int i)
        {
        }

        public static void UpdateCursorPosInEditor(RichTextBox RE, StatusBar StatusBar, int PanelN)
        {
        }

        public static void FindInText(RichTextBox RE, CommonDialog FD, ref bool FF, bool IsRegExp)
        {
        }

        public static void FindInText(TRichEditU RE, CommonDialog FD, ref bool FF, bool IsRegExp)
        {
        }

        // *** функции TStringList
        public static int FindInStrings(StringDictionary List, string s, TStrCompare Compare)
        {
            int result = 0;
            return result;
        }

        public static string RestLowerCase(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static int FindInStringsUL(StringDictionary List, string s)
        {
            int result = 0;
            return result;
        }

        public static int FindPlaceInStrings(StringDictionary List, int p1, int p2, string s, TStrCompare Compare)
        {
            int result = 0;
            return result;
        }

        // *** AskForSelection
        public static DialogResult AskForSelection(string w1, string w2, bool ToFocusFirst, bool WrongYo, bool ReplacedYo, bool WrongYe)
        {
            DialogResult result = null;
            return result;
        }

        public static void PutToIntegerList(ref TIntegerList IL, int i)
        {
        }

        public static bool IsValidRegExpr(string s, ref int ID)
        {
            bool result = false;
            return result;
        }

        public static string ToMetaSymbols(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static int GetTextType(string FileName, int TextType)
        {
            int result = 0;
            return result;
        }

        public bool GetContext_PrevChar()
        {
            bool result;
            return result;
        }

        public bool GetContext_NextChar()
        {
            bool result;
            return result;
        }

        public static string GetContext(int LineN, int PosN, string cWord, ref int di)
        {
            string result = String.Empty;
            return result;
        }

        public static string MarkString(string s, int p, int q)
        {
            string result = String.Empty;
            return result;
        }

        public void MatchRegExp_CalcYeYo(string s, ref int[] r)
        {
        }

        public static void MatchRegExp(string cWord, string RegStr0, TRegExpr RE, string Word1, string Word2, ref int WordN, string Context, int di)
        {
        }

        public static string NoCR(string s)
        {
            string result = String.Empty;
            return result;
        }

        public static bool LookInRegExps(string cWord, int Idx, string Word1, string Word2, ref int WordN)
        {
            bool result = false;
            return result;
        }

        public static void CopyToDicEdit(string s)
        {
        }

        public static void SetButtonCaption(Button b, string s)
        {
        }

        public static bool ContainsWideChar(string s, char c)
        {
            bool result = false;
            return result;
        }

        public static byte UnicodeTextType(string FileName, bool Auto)
        {
            byte result = 0;
            return result;
        }

        public static byte RTFTextType(string FileName)
        {
            byte result = 0;
            return result;
        }

    } // end Main

}

