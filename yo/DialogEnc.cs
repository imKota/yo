using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections.Generic;
 // Диалог с возможностью выбора колдировки
namespace DialogEnc
{
    public class TDialogEnc: OpenFileDialog
    {
        // The attributes used to specify a custom logo template
        public string TemplateRes
        {
          get {
            return FTemplateRes;
          }
          set {
            SetTemplateRes(value);
          }
        }
        // Published declarations
        public TCommandEvent OnCommand
        {
          get {
            return FOnCommand;
          }
          set {
            FOnCommand = value;
          }
        }
        // Private declarations
        private string FTemplateRes = String.Empty;
        private TCommandEvent FOnCommand = null;
        // Public declarations
        public bool SaveDialog = false;
        // эьл диалог сохранения?
        public bool EnableEncoding = false;
        // можно ли выбирать кодировку?
        public StringDictionary EncodingStrings = null;
        // строка для кодировки
        public int EncodingIndex = 0;
        private void SetTemplateRes(string Value)
        {
        }

        // Protected declarations
        public override void WndProc(ref TMessage Message)
        {
        }

        private void OpenDialog1OnShow(Object Sender)
        {
        }

        // индекс кодировки
        //Constructor  Create( AOwner)
        public TDialogEnc(Component AOwner) : base(AOwner)
        {
        }
        //@ Destructor  Destroy()
        ~TDialogEnc()
        {
        }
        private void OpenDialog1OnCommand(ushort ControlID)
        {
        }

        public override bool Execute()
        {
            bool result = false;
            return result;
        }

    } // end TDialogEnc

    public delegate void TCommandEvent(ushort ControlID);
}

namespace DialogEnc.Units
{
    public class DialogEnc
    {
        public static int TmpEncodingIndex = 0;
        // procedure Register;
        public const int idEncoding = 257;
        public const int LB_FILETYPES_ID = 1089;
        public const int LB_DRIVES_ID = 1091;
        public const string strSave = "Save";
        public const string strType = "Save as types:";
        public const string strSaveIn = "Save in:";
    } // end DialogEnc

}

