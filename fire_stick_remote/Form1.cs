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
        Dictionary<string, string> shell_commands_dict = new Dictionary<string, string>();
        bool playing;
        public void call_cmd(string command)
        {
            string key_code = shell_commands_dict[command];

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "adb";
            process.StartInfo.WorkingDirectory = "C:\\adb";
            process.StartInfo.Arguments = key_code;
            process.Start();
            process.WaitForExit();
            log_text.Text += '\n' + command + " command sent to Firestick.";
        }

        public Form1()
        {
            InitializeComponent();
            log_text.Text += "\nComponent initialized sucessfully.";
            log_text.Text += "\nFirestick Remote (v 1.1)";
            log_text.Text += "\n______________________________________\n";

            this.KeyPreview = true;

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

        private void keyboard_input_event(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    button2.Focus();
                    call_cmd("Up");
                    break;
                case "Down":
                    button4.Focus();
                    call_cmd("Down");
                    break;
                case "Right":
                    button3.Focus();
                    call_cmd("Right");
                    break;
                case "Left":
                    button1.Focus();
                    call_cmd("Left");
                    break;
                case "Return":
                    button5.Focus();
                    call_cmd("Enter");
                    break;

                case "A":
                    call_cmd("Left");
                    button1.Focus();
                    break;
                case "D":
                    call_cmd("Right");
                    button3.Focus();
                    break;
                case "S":
                    call_cmd("Down");
                    button4.Focus();
                    break;
                case "W":
                    call_cmd("Up");
                    button2.Focus();
                    break;

                default:
                    break;
            }
        }


        protected override bool IsInputKey(Keys keyData)
        {
            e.Handled = true;
            switch (keyData)
            {
                case Keys.Right:
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


        protected override void OnKeyDown(KeyEventArgs e)
        {
            
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    if (e.Shift)
                    {

                    }
                    else
                    {
                    }
                    break;
            }
        }

        private void up_button_event(object sender, EventArgs e)
        {
            //Up
            call_cmd("Up");
        }

        private void play_pause_event(object sender, EventArgs e)
        {
            //Play/Pause
            call_cmd("Play/Pause");
            if (playing == true)
            {
                button9.Text = "Play";
            }
            else
            {
                button9.Text = "Pause";
            }
            playing = !playing;

        }

        private void right_button_event(object sender, EventArgs e)
        {
            //Right
            call_cmd("Right");
        }

        private void down_button_event(object sender, EventArgs e)
        {
            //Down
            call_cmd("Down");
        }

        private void left_button_event(object sender, EventArgs e)
        {
            //Left
            call_cmd("Left");
        }

        private void back_event(object sender, EventArgs e)
        {
            //Back
            call_cmd("Back");
        }

        private void home_event(object sender, EventArgs e)
        {
            //Home
            call_cmd("Home");
        }

        private void next_event(object sender, EventArgs e)
        {
            //Next
            call_cmd("Next");
        }

        private void enter_event(object sender, EventArgs e)
        {
            //Enter
            call_cmd("Enter");
        }

        private void menu_event(object sender, EventArgs e)
        {
            //Menu
            call_cmd("Menu");
        }

        private void previous_event(object sender, EventArgs e)
        {
            //Previous
            call_cmd("Previous");
        }
    }
}
