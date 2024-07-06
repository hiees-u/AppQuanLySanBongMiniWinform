using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoAN.NET_
{
    public partial class frmMainMenu : Form
    {
        private Button curentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frmMainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count());
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count());
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object btnsender)
        {
            if(btnsender != null)
            {
                if(curentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    curentButton = (Button)btnsender;
                    curentButton.BackColor = color;
                    curentButton.ForeColor = Color.White  ;
                    curentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void DisableButton()
        {
            foreach(Control previousBtn in flowLayoutPanel1.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 50, 76);
                    previousBtn.ForeColor = Color.BurlyWood;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmHeThong(), sender);
            label1.Text = btnHeThong.Text;
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmDatSan(), sender);
            label1.Text = btnDatSan.Text;
        }
          
        private void btnQuanLiSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmQuanLiSan(), sender);
            label1.Text = btnQuanLiSan.Text;
        }

        private void btnQuanLiKinhDoanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmThongKeLichDS(), sender);
            label1.Text = btnQuanLiKinhDoanh.Text;
        }
        private Form activeForms = null;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForms != null)
                activeForms.Close();
            ActiveButton(btnSender);
            activeForms = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }



        

        private void btnZoom_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimize
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)//Maximize
                    this.WindowState = FormWindowState.Maximized;
            else
                    this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();//Close
        }
    }
}
