using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.IO;
namespace KOSploitV2
{
    /* 
     
          _______    ______    ______    ______   _______   __    __  __    __  __    __   ______         __     __   ______        ______  
/       \  /      \  /      \  /      \ /       \ /  |  /  |/  \  /  |/  |  /  | /      \       /  |   /  | /      \      /      \ 
$$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$  |$$$$$$$  |$$ |  $$ |$$  \ $$ |$$ | /$$/ /$$$$$$  |      $$ |   $$ |/$$$$$$  |    /$$$$$$  |
$$ |__$$ |$$ |__$$ |$$ \__$$/ $$ \__$$/ $$ |__$$ |$$ |  $$ |$$$  \$$ |$$ |/$$/  $$ \__$$/       $$ |   $$ |$$____$$ |    $$____$$ |
$$    $$< $$    $$ |$$      \ $$      \ $$    $$/ $$ |  $$ |$$$$  $$ |$$  $$<   $$      \       $$  \ /$$/  /    $$/      /    $$/ 
$$$$$$$  |$$$$$$$$ | $$$$$$  | $$$$$$  |$$$$$$$/  $$ |  $$ |$$ $$ $$ |$$$$$  \   $$$$$$  |       $$  /$$/  /$$$$$$/      /$$$$$$/  
$$ |__$$ |$$ |  $$ |/  \__$$ |/  \__$$ |$$ |      $$ \__$$ |$$ |$$$$ |$$ |$$  \ /  \__$$ |        $$ $$/   $$ |_____  __ $$ |_____ 
$$    $$/ $$ |  $$ |$$    $$/ $$    $$/ $$ |      $$    $$/ $$ | $$$ |$$ | $$  |$$    $$/          $$$/    $$       |/  |$$       |
$$$$$$$/  $$/   $$/  $$$$$$/   $$$$$$/  $$/        $$$$$$/  $$/   $$/ $$/   $$/  $$$$$$/            $/     $$$$$$$$/ $$/ $$$$$$$$/ 
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
         
         */


    public partial class Form1 : Form
    {
        ExploitAPI exec = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
            dlgOpen.Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgOpen.Title = "Please select a script to open.";
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            exec.SendCommand("kill me");
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            exec.SendCommand("btools me");
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            exec.SetWalkSpeed(txtTarget.Text, int.Parse(txtSpeed.Text));
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            exec.SendLuaScript("game.Players.LocalPlayer.character.Humanoid.JumpPower = " + txtJumpPower.Text);
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
            try
            {
                string script = System.IO.File.ReadAllText(dlgOpen.FileName);
                txtScript.Text = script;
            }
            catch (Exception ex) {
                MessageBox.Show("Error in loading file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            txtScript.Text = "";
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            exec.SendCommand("float " + txtTarget.Text);
        }

        private void flatButton11_Click(object sender, EventArgs e)
        {
            exec.SendCommand("unfloat " + txtTarget.Text);
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            exec.SendCommand("ff " + txtTarget.Text);
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            exec.SendCommand("noff " + txtTarget.Text);
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            exec.SendLuaScript(txtScript.Text);
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            exec.SendLuaCScript(txtScript.Text);
        }

        private void flatButton5_Click_1(object sender, EventArgs e)
        {
            exec.LaunchExploit();
        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            exec.SendCommand("fire " + txtTarget.Text);
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            exec.SendCommand("nofire " + txtTarget.Text);
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            exec.SendLuaScript("local Plr = game:GetService(\"Players\").LocalPlayer\r\nlocal Mouse = Plr:GetMouse()\r\n\r\nMouse.Button1Down:connect(function()\r\nif not game:GetService(\"UserInputService\"):IsKeyDown(Enum.KeyCode.LeftControl) then return end\r\nif not Mouse.Target then return end\r\nPlr.Character:MoveTo(Mouse.Hit.p)\r\nend)\r\n");
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            txtTarget.Text = "me";
        }

        private void flatButton5_Click_2(object sender, EventArgs e)
        {
            exec.LaunchExploit();
        }

        private void skinSploit_Click(object sender, EventArgs e)
        {

        }
    }
}
