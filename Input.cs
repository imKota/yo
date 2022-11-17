using System;
using System.Windows.Forms;
namespace Input
{
    // .$DEFINE Debug
    // to remove garbage after WordWrap on/off/on
    // .$APPTYPE CONSOLE
    // .$WARN UNSAFE_CODE OFF
    public partial class TInputForm: Form
    {
        public TInputForm()
        {
            InitializeComponent();
        }

        // Public declarations
        // TInputForm
        public void GetInteger(ref int v, int vmin, int vmax)
        {
        }

        public void FormShow(Object Sender)
        {
        }

        public void FormShortCut(ref TWMKey Msg, ref bool Handled)
        {
        }

    } // end TInputForm

}

namespace Input.Units
{
    public class Input
    {
        public static TInputForm InputForm = null;
    } // end Input

}

