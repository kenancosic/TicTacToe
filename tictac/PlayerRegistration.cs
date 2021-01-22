using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictac
{
    public partial class PlayerRegistration : Form
    {
        public PlayerRegistration()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            TicTacToe.setPlayerNames(txtPlayerOneName.Text, txtPlayerTwoName.Text);
            this.Close();
        }



        private void txtPlayerTwoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btnPlay.PerformClick();

        }
    }
}
