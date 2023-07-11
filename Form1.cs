using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace PythonCodeHelper
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set textboxes to not visible
            parameter_textbox.Visible = false;
            prints_textbox.Visible = false;
            preview_richbox.Visible = false;
            hide_preview_checkbox.Visible = false;
        }
        static class Global
        {
            public static string fileName = ""; // File name global variable
            public static string function_name = "";
            public static bool parameter_checked = false;
            public static bool prints_checked = false;
            public static bool para_empty = false; // para_empty
            public static bool function_empty = false; // function_empty // para_empty function_empty invalid_dic
            public static bool invalid_dic = false; // invalid_dic 

        }
        private void pictureBox1_Click(object sender, EventArgs e) // Close app icon click
        {
            DialogResult dialogResult = MessageBox.Show("", "Are you sure you want to quit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void label1_Click(object sender, EventArgs e) // Python  code helper label click
        {
            MessageBox.Show("Python Code Helper, What is it? Well its a program made for python beginners, or people that are lazy. Its coded in C# by Faxe#4578.");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Discord link label click
        {
            Process.Start("https://discord.gg/j7U3epyFaC"); // opens discord link
        }
        private void selectfile_button_Click(object sender, EventArgs e) // select file button click
        {
            OpenFileDialog dlg = new OpenFileDialog(); // file dialog 
            dlg.Filter = "Python files (*.py)|*.py"; // so only python files can be selected
            dlg.InitialDirectory = @"c:\"; // sets the dictory to start at
            dlg.ShowDialog(); // shows the file dialog

            if (dlg.ShowDialog() == DialogResult.OK) // when file is selected and open is pressed 
            {
                string fn;
                fn = dlg.FileName;
                textbox_filedic.Text = fn;
                Global.fileName = fn;
            }
        }
        private void textbox_filedic_TextChanged(object sender, EventArgs e) // file directory text box
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) // file dialog 
        {

        }
        private void parameter_checkbox_CheckedChanged(object sender, EventArgs e) // parameter check box
        {
            if (parameter_checkbox.Checked == true) // if parameter checkbox is checked
            {
                Global.parameter_checked = true; // set the paramater checked variable to true
                parameter_textbox.Visible = true;// sets the textbox to visible
            } else if (parameter_checkbox.Checked == false) // else if checkbox is not checked
            {
                Global.parameter_checked = false; // set parameter checked to false 
                parameter_textbox.Visible = false; // sets textbox to not visible
            }
        }
        private void prints_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (prints_checkbox.Checked == true)
            {
                Global.prints_checked = true;
                prints_textbox.Visible = true;
            }
            else if (prints_checkbox.Checked == false)
            {
                Global.prints_checked = false;
                prints_textbox.Visible = false;
            }
        }
        private void functionname_textbox_TextChanged(object sender, EventArgs e) // function name text box 
        {
            Global.function_name = functionname_textbox.Text;
            const string quote = "\"";
            if (preview_richbox.Visible)
            {
                if (prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                {
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                {
                    var c = "\n\ndef " + Global.function_name + "():\n";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                {
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                {
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n";
                    preview_richbox.Text = c;
                }
            }
        }
        private void submit_button_pyfunction_Click(object sender, EventArgs e) // on submit button click - python function creater
        {
            try
            {

                const string quote = "\"";
                if (functionname_textbox.Text == "" || textbox_filedic.Text == "")
                {
                    MessageBox.Show("Something went wrong, check for any invalid values");
                }
                else if (prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                {
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "";
                    TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                    s.Write(c + "\n\n\n");
                    s.Close();
                } else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                {
                    var c = "\n\ndef " + Global.function_name + "():\n";
                    TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                    s.Write(c + "\n\n\n");
                    s.Close();
                } else if (prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                {
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "";
                    TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                    s.Write(c + "\n\n\n");
                    s.Close();
                } else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                {
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n";
                    TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                    s.Write(c + "\n\n\n");
                    s.Close();
                }
            }
            catch { MessageBox.Show("ERROR, Something went wrong, check for any invalid values"); }
        }
        private void code_saver_textbox_TextChanged(object sender, EventArgs e) // Code gets saven in here to write to file
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void template_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What is an python template? Well its basicly just a thing that sets up an python file with basic code in an folder");
        }
        private void readme_file_label_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void code_in_python_file_label_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void select_directory_button_Click(object sender, EventArgs e) // select directory button click
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                file_path_directory_textbox.Text = ofd.SelectedPath;
            }
        }
        private void label2_Click(object sender, EventArgs e) // function name label click
        {
            MessageBox.Show("Choose the name of the function");
        }
        private void readme_label_Click(object sender, EventArgs e) // readme file label click
        {
            MessageBox.Show("Check this checkbox if you want to create an readme file inside the directory with content in it");  // braincells
        }
        private void codein_python_file_label_Click(object sender, EventArgs e) // code in python label click
        {
            MessageBox.Show("Check this checkbox if you want code in the created python file"); // braincells
        }
        private void submit_template_button_Click(object sender, EventArgs e) // Submit button - template creater function
        {
            try
            {
                if (file_path_directory_textbox.Text == "" || file_path_directory_textbox.Text == " " || (!Directory.Exists(file_path_directory_textbox.Text))) // Checks a bunch of things, im to lazy to explain
                {
                    MessageBox.Show("Something went wrong, check for any invalid values"); // if you have braincells you know this
                }
                else if (readme_file_checkbox.Checked == true && code_in_python_file_label.Checked == true) // and this
                {
                    const string quote = "\"";
                    string vrs = "okman = 2\nokwomen = 3\nokanimal = 4\n";
                    string comment = "#This was made by Faxe Python Code helper - Faxe#4578\n";
                    string result = "result = okman+okwomen+okanimal\n\n";
                    string code = "Print(f" + quote + "Hello world, anyways the result is:{result}" + quote + ")";
                    string readme_content = "Hey, this readme was created by Faxe python code helper - Faxe#4578";
                    File.WriteAllText(Path.Combine(file_path_directory_textbox.Text, "main.py"), comment + vrs + result + code);
                    File.WriteAllText(Path.Combine(file_path_directory_textbox.Text, "readme.md"), readme_content);
                }
                else if (readme_file_checkbox.Checked == true)
                {
                    string readme_content = "Hey, this readme was created by Faxe python code helper - Faxe#4578";
                    File.WriteAllText(Path.Combine(file_path_directory_textbox.Text, "main.py"), "");
                    File.WriteAllText(Path.Combine(file_path_directory_textbox.Text, "readme.md"), readme_content);
                }
            }
            catch { MessageBox.Show("ERROR, Something went wrong, check for any invalid values"); } // and this
        }
        private void imports_label_Click(object sender, EventArgs e) { MessageBox.Show("Click Submit to import modules in the selected file!"); } // imports label click


        private void imports_button_Click(object sender, EventArgs e)
        {
            try {
                if (textbox_filedic.Text == "" || textbox_filedic.Text == " ")
                {
                    MessageBox.Show("Something went wrong, check for any invalid values");
                }
                else
                {
                    string modules = "import requests\nfrom colorama import Fore,init\nfrom time import sleep\nimport json";
                    string content = File.ReadAllText(textbox_filedic.Text);
                    content = modules + "\n" + content+"\n";
                    File.WriteAllText(textbox_filedic.Text, content);
                }
            } catch { MessageBox.Show("ERROR, Something went wrong, check for any invalid values"); }
        }
        private void help_label_Click(object sender, EventArgs e) { MessageBox.Show("Do you need help/support, then contact Faxe on discord:faxethedev Remember, to see what different things do click on the labels/texts"); }


        private void label6_Click(object sender, EventArgs e) { MessageBox.Show("Python classes provide all the standard features of Object Oriented Programming: the class inheritance mechanism allows multiple base classes, a derived class can override any methods of its base class or classes, and a method can call the method of a base class with the same name."); }// create class label click


        private void createfunction_label_Click(object sender, EventArgs e) { MessageBox.Show("This creates a function for you, in the selected python file"); }


        private void class_name_label_Click(object sender, EventArgs e) { MessageBox.Show("Choose the class name"); }
        private void submit_button_createclass_Click(object sender, EventArgs e)
        {
            try
            {
                const string quote = "\"";
                string class_name = "class " + classname_textbox.Text + ":\n";
                string function1 = "  def __init__(mysillyobject, name, age):\n";
                string function1_vars = "     mysillyobject.name = name\n     mysillyobject.age = age\n";
                string function2 = "  def myfunc(abc):\n";
                string function2_printext = "Hello my name is ";
                string function2_print = "      print(" + quote + function2_printext + quote + "+ abc.name)";
                string result = class_name + function1 + function1_vars + function2 + function2_print;
                File.WriteAllText(textbox_filedic.Text, result);
            } catch { MessageBox.Show("ERROR, Something went wrong, check for any invalid values"); }
        }
        private void preview_button_createclass_Click(object sender, EventArgs e)
        {
            try
            {
                if(classname_textbox.Text == "" || classname_textbox.Text == " ")
                {
                    MessageBox.Show("Something went wrong, check for any invalid values");
                } else
                {
                    preview_richbox.Visible = true;
                    hide_preview_checkbox.Visible = true;
                    hide_preview_checkbox.Checked = false;
                    const string quote = "\"";
                    string class_name = "class " + classname_textbox.Text + ":\n";
                    string function1 = "  def __init__(mysillyobject, name, age):\n";
                    string function1_vars = "     mysillyobject.name = name\n     mysillyobject.age = age\n";
                    string function2 = "  def myfunc(abc):\n";
                    string function2_printext = "Hello my name is ";
                    string function2_print = "      print(" + quote + function2_printext + quote + "+ abc.name)";
                    string result = class_name + function1 + function1_vars + function2 + function2_print;
                    preview_richbox.Text = result;
                }
            } catch { MessageBox.Show("ERROR, something went wrong, please check for any invalid values!"); }
        }
        private void hide_preview_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (hide_preview_checkbox.Checked == true)
            {
                preview_richbox.Text = "";
                preview_richbox.Visible = false;
                hide_preview_checkbox.Visible = false;
            }
        }
        private void preview_button_createfunction_Click(object sender, EventArgs e)
        {
            try
            {
                if (functionname_textbox.Text == "" || functionname_textbox.Text == " ")
                {
                    MessageBox.Show("Something went wrong, check for any invalid values");
                }

                else if (prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                {
                    preview_richbox.Visible = true;
                    hide_preview_checkbox.Visible = true;
                    hide_preview_checkbox.Checked = false;
                    const string quote = "\"";
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                {
                    preview_richbox.Visible = true;
                    hide_preview_checkbox.Visible = true;
                    hide_preview_checkbox.Checked = false;
                    var c = "\n\ndef " + Global.function_name + "():\n";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                {
                    preview_richbox.Visible = true;
                    hide_preview_checkbox.Visible = true;
                    hide_preview_checkbox.Checked = false;
                    const string quote = "\"";
                    string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                    var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "";
                    preview_richbox.Text = c;
                }
                else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                {
                    preview_richbox.Visible = true;
                    hide_preview_checkbox.Visible = true;
                    hide_preview_checkbox.Checked = false;
                    var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n";
                    preview_richbox.Text = c;
                }
            } catch { MessageBox.Show("ERROR, something went wrong, please check for any invalid values!"); }
        }
        private void classname_textbox_TextChanged(object sender, EventArgs e)
        {
            if (preview_richbox.Visible)
            {
                const string quote = "\"";
                string class_name = "class " + classname_textbox.Text + ":\n";
                string function1 = "  def __init__(mysillyobject, name, age):\n";
                string function1_vars = "     mysillyobject.name = name\n     mysillyobject.age = age\n";
                string function2 = "  def myfunc(abc):\n";
                string function2_printext = "Hello my name is ";
                string function2_print = "      print(" + quote + function2_printext + quote + "+ abc.name)";
                string result = class_name + function1 + function1_vars + function2 + function2_print;
                preview_richbox.Text = result;
            }
        }
        private void parameter_textbox_TextChanged(object sender, EventArgs e)
        {
            if (preview_richbox.Visible)
            {
                const string quote = "\"";
                if (preview_richbox.Visible)
                {
                    if (prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                    {
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                        var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "";
                        preview_richbox.Text = c;
                    }
                    else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                    {
                        var c = "\n\ndef " + Global.function_name + "():\n";
                        preview_richbox.Text = c;
                    }
                    else if (prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                    {
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                        var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "";
                        preview_richbox.Text = c;
                    }
                    else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                    {
                        var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n";
                        preview_richbox.Text = c;
                    }
                }
            }
        }
        private void prints_textbox_TextChanged(object sender, EventArgs e)
        {
            if (preview_richbox.Visible)
            {
                const string quote = "\"";
                if (preview_richbox.Visible)
                {
                    if(prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                    {
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                        var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "";
                        preview_richbox.Text = c;
                    }
                    else if(prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                    {
                        var c = "\n\ndef " + Global.function_name + "():\n";
                        preview_richbox.Text = c;
                    }
                    else if(prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                    {
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")";
                        var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "";
                        preview_richbox.Text = c;
                    }
                    else if(prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                    {
                        var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n";
                        preview_richbox.Text = c;
                    }
                }
            }
        }
        private void preview_button_template_Click(object sender, EventArgs e)
        {
            if(code_in_python_file_label.Checked)
            {
                preview_richbox.Visible = true;
                hide_preview_checkbox.Visible = true;
                hide_preview_checkbox.Checked = false;
                const string quote = "\"";
                string vrs = "okman = 2\nokwomen = 3\nokanimal = 4\n";
                string comment = "#This was made by Faxe Python Code helper - Faxe#4578\n";
                string result = "result = okman+okwomen+okanimal\n\n";
                string code = "Print(f" + quote + "Hello world, anyways the result is:{result}" + quote + ")";
                preview_richbox.Text = vrs + comment + result + code;
            } else { MessageBox.Show("Code in python file checkbox, needs to checked!"); }
        } 
        private void preview_button_imports_Click(object sender, EventArgs e)
        {
            preview_richbox.Visible = true;
            hide_preview_checkbox.Visible = true;
            hide_preview_checkbox.Checked = false;
            string modules = "import requests\nfrom colorama import Fore,init\nfrom time import sleep\nimport json";
            preview_richbox.Text = modules;
        }
        private void class_run_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Run from file path = Yes\nRun code in new file = No (directory path required)", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    if(textbox_filedic.Text == ""|| textbox_filedic.Text == " ")
                    {
                        MessageBox.Show("Invalid file path!");
                    } 
                    else
                    {
                        const string quote = "\"";
                        string class_name = "class " + classname_textbox.Text + ":\n";
                        string function1 = "  def __init__(mysillyobject, name, age):\n";
                        string function1_vars = "     mysillyobject.name = name\n     mysillyobject.age = age\n";
                        string function2 = "  def myfunc(abc):\n";
                        string function2_printext = "Hello my name is ";
                        string function2_print = "      print(" + quote + function2_printext + quote + "+ abc.name)\n\n      input("+quote+"ok dude"+quote+")\n";
                        string function2_code = "p1 = "+classname_textbox.Text+"(" + quote + "John" + quote + ", 36)\np1.myfunc()";
                        string result = class_name + function1 + function1_vars + function2 + function2_print + function2_code;
                        File.WriteAllText(textbox_filedic.Text, result);
                        Process.Start(textbox_filedic.Text);
                    }
                }
                if (res==DialogResult.No)
                {
                    if (file_path_directory_textbox.Text == "" || file_path_directory_textbox.Text == " ")
                    {
                        MessageBox.Show("Invalid Directory path");
                    } 
                    else
                    {
                        const string quote = "\"";
                        string class_name = "class " + classname_textbox.Text + ":\n";
                        string function1 = "  def __init__(mysillyobject, name, age):\n";
                        string function1_vars = "     mysillyobject.name = name\n     mysillyobject.age = age\n";
                        string function2 = "  def myfunc(abc):\n";
                        string function2_printext = "Hello my name is ";
                        string function2_print = "      print(" + quote + function2_printext + quote + "+ abc.name)\n\n      input(" + quote + "ok dude" + quote + ")\n";
                        string function2_code = "p1 = " + classname_textbox.Text + "(" + quote + "John" + quote + ", 36)\np1.myfunc()";
                        string result = class_name+function1+function1_vars+function2+function2_print+function2_code;
                        File.WriteAllText(Path.Combine(file_path_directory_textbox.Text, "class.py"), result);
                        Process.Start(file_path_directory_textbox.Text+"/class.py");
                    }
                }
                if (res==DialogResult.Cancel) { }
            } catch { MessageBox.Show("ERROR, something went wrong, please check for any invalid values!"); }
        }
        private void button1_Click(object sender, EventArgs e) // run button - function creater
        {
            try
            {
               
                DialogResult res=MessageBox.Show("Run from file path = Yes\nRun code in new file = No (directory path required)", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (res==DialogResult.Yes)
                {
                if (textbox_filedic.Text == "" || textbox_filedic.Text == " " || functionname_textbox.Text == "" || functionname_textbox.Text == " ") {
                 MessageBox.Show("Something went wrong, check for any invalid values"); 
                    }
                    else if (prints_checkbox.Checked == true && (parameter_checkbox.Checked == true)) // checks if prints checkbox is checked & if parameter check box is not checked
                    {
                        const string quote = "\"";
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")\n";
                        var c = $"\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n" + print1 + "   input(" + quote + "ok dude" + quote + ")\n\n"+Global.function_name+"()";
                        TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                        s.Write(c + "\n\n\n");
                        s.Close();
                        Process.Start(textbox_filedic.Text);
                    }
                    else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == false))
                    {
                        const string quote = "\"";
                        var c = "\n\ndef " + Global.function_name + "():\n    input("+quote+"ok dude"+quote+ ")\n\n"+Global.function_name+"()";
                        TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                        s.Write(c + "\n\n\n");
                        s.Close();
                        Process.Start(textbox_filedic.Text);
                    }
                    else if (prints_checkbox.Checked = true && (parameter_checkbox.Checked == false))
                    {
                        const string quote = "\"";
                        string print1 = "   print(" + quote + prints_textbox.Text + quote + ")\n";
                        var c = "\n\ndef " + Global.function_name + "():\n" + print1 + "   input(" + quote+"ok dude"+quote+")\n\n"+Global.function_name+"()";
                        TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                        s.Write(c + "\n\n\n");
                        s.Close();
                        Process.Start(textbox_filedic.Text);
                    }
                    else if (prints_checkbox.Checked == false && (parameter_checkbox.Checked == true))
                    {
                        const string quote = "\"";
                        var c = "\n\ndef " + Global.function_name + "(" + parameter_textbox.Text + "):\n    input(" + quote + "ok dude" + quote + ")\n\n"+Global.function_name+"()";
                        TextWriter s = new StreamWriter(textbox_filedic.Text, true);
                        s.Write(c + "\n\n\n");
                        s.Close();
                        Process.Start(textbox_filedic.Text);
                    }
                }
                if (res==DialogResult.No)
                {

                }
                if (res==DialogResult.Cancel) { }
            } catch { MessageBox.Show("ERROR, something went wrong, please check for any invalid values!"); }
        }
    }
}
