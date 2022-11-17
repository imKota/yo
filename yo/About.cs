using System;
using System.Windows.Forms;
using Commons;
namespace About
{
    // .$DEFINE Debug
    // to remove garbage after WordWrap on/off/on
    // .$APPTYPE CONSOLE
    // .$WARN UNSAFE_CODE OFF
    public partial class TAboutForm: Form
    {
        public TAboutForm()
        {
            InitializeComponent();
        }

        public void Button1Click(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void lEmailDblClick(System.Object Sender, System.EventArgs _e1)
        {
        }

        public void lURLDblClick(System.Object Sender, System.EventArgs _e1)
        {
        }

    } // end TAboutForm

}

namespace About.Units
{
    public class About
    {
        public static TAboutForm AboutForm = null;
    } // end About

}

