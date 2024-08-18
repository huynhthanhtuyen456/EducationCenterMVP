using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCenter
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            ShowTeacherViewBtn.Click += delegate { ShowTeacherView?.Invoke(this, EventArgs.Empty); };
            ShowStudentViewBtn.Click += delegate { ShowStudentView?.Invoke(this, EventArgs.Empty); };
            ShowSubjectViewBtn.Click += delegate { ShowSubjectView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler? ShowTeacherView;
        public event EventHandler? ShowStudentView;
        public event EventHandler? ShowSubjectView;

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowTeacherView?.Invoke(this, EventArgs.Empty);
        }
    }
}
