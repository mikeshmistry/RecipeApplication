using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApplication.UI
{
    public partial class RecipeApplication : Form
    {

        private ErrorProvider ErrorProvider { get; set; }
        
        public RecipeApplication()
        {
            InitializeComponent();
            ErrorProvider = new ErrorProvider();
            
        
        }

      
    }
}
