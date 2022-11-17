using System;
using System.Windows.Forms;
namespace FileProp
{
    public partial class TFilePropForm: Form
    {
        public TFilePropForm()
        {
            InitializeComponent();
        }

        public void FormShortCut(ref TWMKey Msg, ref bool Handled)
        {
        }

    } // end TFilePropForm

}

namespace FileProp.Units
{
    public class FileProp
    {
        public static TFilePropForm FilePropForm = null;
    } // end FileProp

}

