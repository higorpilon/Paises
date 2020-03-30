using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paises.Services
{
   public class DialogService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(title, message);
        }
    }
}
