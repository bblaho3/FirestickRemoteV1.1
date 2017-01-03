using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fire_stick_remote
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> shell_commands_dict;
        bool playing;
        public void call_cmd(string key_code)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "adb";
            process.StartInfo.WorkingDirectory = "C:\\adb";
            process.StartInfo.Arguments = key_code;
            process.Start();
            process.WaitForExit();
        }

        public Form1()
        {
            InitializeComponent();

            shell_commands_dict.Add("Menu", "shell input event 1");
            shell_commands_dict.Add("Home", "shell input event 3");
            shell_commands_dict.Add("Back", "shell input event 4");

            shell_commands_dict.Add("Up", "shell input event 19");
            shell_commands_dict.Add("Down", "shell input event 20");
            shell_commands_dict.Add("Left", "shell input event 21");
            shell_commands_dict.Add("Right", "shell input event 22");
            shell_commands_dict.Add("Enter", "shell input event 66");
            
            shell_commands_dict.Add("Play/Pause", "shell input event 85");
            shell_commands_dict.Add("Previous", "shell input event 88");
            shell_commands_dict.Add("Next", "shell input event 87");

            playing = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Home
            call_cmd(shell_commands_dict["Home"]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Next
            call_cmd(shell_commands_dict["Next"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Up
            call_cmd(shell_commands_dict["Up"]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Right
            call_cmd(shell_commands_dict["Right"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Down
            call_cmd(shell_commands_dict["Down"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Left
            call_cmd(shell_commands_dict["Left"]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Enter
            call_cmd(shell_commands_dict["Enter"]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Back
            call_cmd(shell_commands_dict["Back"]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Menu
            call_cmd(shell_commands_dict["Menu"]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Play/Pause
            call_cmd(shell_commands_dict["Play/Pause"]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Previous
            call_cmd(shell_commands_dict["Previous"]);
        }

        private void key_press_event(object sender, KeyPressEventArgs e)
        {

        }

        private void keyboard_input_event(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode.ToString())
            {
                case "Up":



                    break;
                case "Return":
                    call_cmd("shell input keyevent 66");
                    break;

                default:
                    break;
            }
        }


    protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                     call_cmd("")
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
