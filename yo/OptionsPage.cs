using System;
using System.Drawing;
using System.Windows.Forms;
namespace OptionsPage
{
    public partial class TOptionsForm: Form
    {
        public TOptionsForm()
        {
            InitializeComponent();
        }

        // Private declarations
        private void SetSelBgColor(Color AColor)
        {
        }

        private void ShowEditor()
        {
        }

        private bool SetOptions()
        {
            bool result = false;
            return result;
        }

        public void bOKClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bOKSaveClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bCancelClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void FormShow(Object Sender)
        {
        }

        public void bFontClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        private void SetColor(ref Color c)
        {
        }

        public void bMarkClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void bBackMarkClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void cbClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        // Note: the original parameters are Object Sender, ref char Key
        public void FormKeyPress(System.Object Sender, System.Windows.Forms.KeyPressEventArgs _e1)
        {
        }

    } // end TOptionsForm

    public struct TOptions
    {
        public bool CheckYo;
        public bool NoVarOnly;
        public bool VarOnly;
        public bool AlwaysAsk;
        public bool ToConfirmAbbr;
        public bool ToConfirmCap;
        public bool ToConfirmEllipsis;
        public bool ProposeLast;
        public bool RegExprs;
        public bool FastScroll;
        public bool Mark;
        public bool WordWrap;
        public bool LastFile;
        public bool ToConfirmClose;
        public bool FBFormat;
        public bool AutoUnicode;
        public int LinesBelow;
        public string EditorFontName;
        public string EditorFontCharset;
        public int EditorFontSize;
        public Color clMark;
        public Color clBackMark;
        public Color clEditorWindow;
        public bool FontEnabled;
        public bool RegExprsEnabled;
        public string ProxyName;
        public int ProxyPort;
        public bool ShowToolBar;
    } // end TOptions

}

namespace OptionsPage.Units
{
    public class OptionsPage
    {
        public static TOptionsForm OptionsForm = null;
        public static TOptions NewYoOptions = null;
        public static TOptions YoOptions = null;
        public static TOptions DefaultYoOptions = null;
    } // end OptionsPage

}

