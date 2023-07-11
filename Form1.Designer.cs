
namespace PythonCodeHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.selectfile_button = new System.Windows.Forms.Button();
            this.textbox_filedic = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.submit_button_pyfunction = new System.Windows.Forms.Button();
            this.createfunction_label = new System.Windows.Forms.Label();
            this.parameter_checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.functionname_textbox = new System.Windows.Forms.TextBox();
            this.parameter_textbox = new System.Windows.Forms.TextBox();
            this.prints_checkbox = new System.Windows.Forms.CheckBox();
            this.prints_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.template_label = new System.Windows.Forms.Label();
            this.readme_file_checkbox = new System.Windows.Forms.CheckBox();
            this.select_directory_button = new System.Windows.Forms.Button();
            this.code_in_python_file_label = new System.Windows.Forms.CheckBox();
            this.submit_template_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.file_path_directory_textbox = new System.Windows.Forms.TextBox();
            this.readme_label = new System.Windows.Forms.Label();
            this.codein_python_file_label = new System.Windows.Forms.Label();
            this.imports_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imports_button = new System.Windows.Forms.Button();
            this.help_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.class_name_label = new System.Windows.Forms.Label();
            this.classname_textbox = new System.Windows.Forms.TextBox();
            this.submit_button_createclass = new System.Windows.Forms.Button();
            this.preview_richbox = new System.Windows.Forms.RichTextBox();
            this.preview_button_createclass = new System.Windows.Forms.Button();
            this.preview_button_createfunction = new System.Windows.Forms.Button();
            this.preview_button_template = new System.Windows.Forms.Button();
            this.preview_button_imports = new System.Windows.Forms.Button();
            this.hide_preview_checkbox = new System.Windows.Forms.CheckBox();
            this.class_run_button = new System.Windows.Forms.Button();
            this.run_button_function = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PythonCodeHelper.Properties.Resources.icons8_multiply_32;
            this.pictureBox1.Location = new System.Drawing.Point(1868, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1586, 1041);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Python code helper - Faxe#4578";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1494, 1041);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 30);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // selectfile_button
            // 
            this.selectfile_button.BackColor = System.Drawing.Color.Black;
            this.selectfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectfile_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectfile_button.ForeColor = System.Drawing.Color.White;
            this.selectfile_button.Location = new System.Drawing.Point(3, 973);
            this.selectfile_button.Name = "selectfile_button";
            this.selectfile_button.Size = new System.Drawing.Size(163, 53);
            this.selectfile_button.TabIndex = 4;
            this.selectfile_button.Text = "Select file";
            this.selectfile_button.UseVisualStyleBackColor = false;
            this.selectfile_button.Click += new System.EventHandler(this.selectfile_button_Click);
            // 
            // textbox_filedic
            // 
            this.textbox_filedic.BackColor = System.Drawing.Color.Black;
            this.textbox_filedic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_filedic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_filedic.ForeColor = System.Drawing.Color.White;
            this.textbox_filedic.Location = new System.Drawing.Point(3, 1047);
            this.textbox_filedic.Name = "textbox_filedic";
            this.textbox_filedic.Size = new System.Drawing.Size(163, 22);
            this.textbox_filedic.TabIndex = 5;
            this.textbox_filedic.TextChanged += new System.EventHandler(this.textbox_filedic_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // submit_button_pyfunction
            // 
            this.submit_button_pyfunction.BackColor = System.Drawing.Color.Black;
            this.submit_button_pyfunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_button_pyfunction.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button_pyfunction.Location = new System.Drawing.Point(742, 426);
            this.submit_button_pyfunction.Name = "submit_button_pyfunction";
            this.submit_button_pyfunction.Size = new System.Drawing.Size(105, 43);
            this.submit_button_pyfunction.TabIndex = 6;
            this.submit_button_pyfunction.Text = "Submit";
            this.submit_button_pyfunction.UseVisualStyleBackColor = false;
            this.submit_button_pyfunction.Click += new System.EventHandler(this.submit_button_pyfunction_Click);
            // 
            // createfunction_label
            // 
            this.createfunction_label.AutoSize = true;
            this.createfunction_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createfunction_label.ForeColor = System.Drawing.Color.White;
            this.createfunction_label.Location = new System.Drawing.Point(737, 26);
            this.createfunction_label.Name = "createfunction_label";
            this.createfunction_label.Size = new System.Drawing.Size(160, 30);
            this.createfunction_label.TabIndex = 7;
            this.createfunction_label.Text = "Create function";
            this.createfunction_label.Click += new System.EventHandler(this.createfunction_label_Click);
            // 
            // parameter_checkbox
            // 
            this.parameter_checkbox.AutoSize = true;
            this.parameter_checkbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameter_checkbox.ForeColor = System.Drawing.Color.White;
            this.parameter_checkbox.Location = new System.Drawing.Point(742, 194);
            this.parameter_checkbox.Name = "parameter_checkbox";
            this.parameter_checkbox.Size = new System.Drawing.Size(135, 34);
            this.parameter_checkbox.TabIndex = 8;
            this.parameter_checkbox.Text = "Parameters";
            this.parameter_checkbox.UseVisualStyleBackColor = true;
            this.parameter_checkbox.CheckedChanged += new System.EventHandler(this.parameter_checkbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(737, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Function name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // functionname_textbox
            // 
            this.functionname_textbox.BackColor = System.Drawing.Color.Black;
            this.functionname_textbox.ForeColor = System.Drawing.Color.White;
            this.functionname_textbox.Location = new System.Drawing.Point(742, 161);
            this.functionname_textbox.Name = "functionname_textbox";
            this.functionname_textbox.Size = new System.Drawing.Size(138, 20);
            this.functionname_textbox.TabIndex = 10;
            this.functionname_textbox.TextChanged += new System.EventHandler(this.functionname_textbox_TextChanged);
            // 
            // parameter_textbox
            // 
            this.parameter_textbox.BackColor = System.Drawing.Color.Black;
            this.parameter_textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameter_textbox.ForeColor = System.Drawing.Color.White;
            this.parameter_textbox.Location = new System.Drawing.Point(742, 234);
            this.parameter_textbox.Name = "parameter_textbox";
            this.parameter_textbox.Size = new System.Drawing.Size(138, 22);
            this.parameter_textbox.TabIndex = 11;
            this.parameter_textbox.TextChanged += new System.EventHandler(this.parameter_textbox_TextChanged);
            // 
            // prints_checkbox
            // 
            this.prints_checkbox.AutoSize = true;
            this.prints_checkbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prints_checkbox.ForeColor = System.Drawing.Color.White;
            this.prints_checkbox.Location = new System.Drawing.Point(742, 262);
            this.prints_checkbox.Name = "prints_checkbox";
            this.prints_checkbox.Size = new System.Drawing.Size(84, 34);
            this.prints_checkbox.TabIndex = 13;
            this.prints_checkbox.Text = "Prints";
            this.prints_checkbox.UseVisualStyleBackColor = true;
            this.prints_checkbox.CheckedChanged += new System.EventHandler(this.prints_checkbox_CheckedChanged);
            // 
            // prints_textbox
            // 
            this.prints_textbox.BackColor = System.Drawing.Color.Black;
            this.prints_textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prints_textbox.ForeColor = System.Drawing.Color.White;
            this.prints_textbox.Location = new System.Drawing.Point(742, 302);
            this.prints_textbox.Name = "prints_textbox";
            this.prints_textbox.Size = new System.Drawing.Size(138, 22);
            this.prints_textbox.TabIndex = 14;
            this.prints_textbox.TextChanged += new System.EventHandler(this.prints_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(737, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "------------------";
            // 
            // template_label
            // 
            this.template_label.AutoSize = true;
            this.template_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.template_label.ForeColor = System.Drawing.Color.White;
            this.template_label.Location = new System.Drawing.Point(968, 26);
            this.template_label.Name = "template_label";
            this.template_label.Size = new System.Drawing.Size(179, 30);
            this.template_label.TabIndex = 16;
            this.template_label.Text = "Python template ";
            this.template_label.Click += new System.EventHandler(this.template_label_Click);
            // 
            // readme_file_checkbox
            // 
            this.readme_file_checkbox.AutoSize = true;
            this.readme_file_checkbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readme_file_checkbox.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.readme_file_checkbox.Location = new System.Drawing.Point(973, 126);
            this.readme_file_checkbox.Name = "readme_file_checkbox";
            this.readme_file_checkbox.Size = new System.Drawing.Size(15, 14);
            this.readme_file_checkbox.TabIndex = 17;
            this.readme_file_checkbox.UseVisualStyleBackColor = true;
            this.readme_file_checkbox.CheckedChanged += new System.EventHandler(this.readme_file_label_CheckedChanged);
            // 
            // select_directory_button
            // 
            this.select_directory_button.BackColor = System.Drawing.Color.Black;
            this.select_directory_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select_directory_button.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_directory_button.Location = new System.Drawing.Point(199, 973);
            this.select_directory_button.Name = "select_directory_button";
            this.select_directory_button.Size = new System.Drawing.Size(222, 53);
            this.select_directory_button.TabIndex = 18;
            this.select_directory_button.Text = "Select directory";
            this.select_directory_button.UseVisualStyleBackColor = false;
            this.select_directory_button.Click += new System.EventHandler(this.select_directory_button_Click);
            // 
            // code_in_python_file_label
            // 
            this.code_in_python_file_label.AutoSize = true;
            this.code_in_python_file_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_in_python_file_label.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.code_in_python_file_label.Location = new System.Drawing.Point(973, 160);
            this.code_in_python_file_label.Name = "code_in_python_file_label";
            this.code_in_python_file_label.Size = new System.Drawing.Size(15, 14);
            this.code_in_python_file_label.TabIndex = 19;
            this.code_in_python_file_label.UseVisualStyleBackColor = true;
            this.code_in_python_file_label.CheckedChanged += new System.EventHandler(this.code_in_python_file_label_CheckedChanged);
            // 
            // submit_template_button
            // 
            this.submit_template_button.BackColor = System.Drawing.Color.Black;
            this.submit_template_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_template_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_template_button.Location = new System.Drawing.Point(973, 281);
            this.submit_template_button.Name = "submit_template_button";
            this.submit_template_button.Size = new System.Drawing.Size(105, 43);
            this.submit_template_button.TabIndex = 20;
            this.submit_template_button.Text = "Submit";
            this.submit_template_button.UseVisualStyleBackColor = false;
            this.submit_template_button.Click += new System.EventHandler(this.submit_template_button_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // file_path_directory_textbox
            // 
            this.file_path_directory_textbox.BackColor = System.Drawing.Color.Black;
            this.file_path_directory_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.file_path_directory_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_path_directory_textbox.ForeColor = System.Drawing.Color.White;
            this.file_path_directory_textbox.Location = new System.Drawing.Point(199, 1046);
            this.file_path_directory_textbox.Name = "file_path_directory_textbox";
            this.file_path_directory_textbox.Size = new System.Drawing.Size(222, 22);
            this.file_path_directory_textbox.TabIndex = 21;
            // 
            // readme_label
            // 
            this.readme_label.AutoSize = true;
            this.readme_label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.readme_label.ForeColor = System.Drawing.Color.White;
            this.readme_label.Location = new System.Drawing.Point(994, 117);
            this.readme_label.Name = "readme_label";
            this.readme_label.Size = new System.Drawing.Size(117, 30);
            this.readme_label.TabIndex = 22;
            this.readme_label.Text = "readme file";
            this.readme_label.Click += new System.EventHandler(this.readme_label_Click);
            // 
            // codein_python_file_label
            // 
            this.codein_python_file_label.AutoSize = true;
            this.codein_python_file_label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.codein_python_file_label.ForeColor = System.Drawing.Color.White;
            this.codein_python_file_label.Location = new System.Drawing.Point(994, 151);
            this.codein_python_file_label.Name = "codein_python_file_label";
            this.codein_python_file_label.Size = new System.Drawing.Size(186, 30);
            this.codein_python_file_label.TabIndex = 23;
            this.codein_python_file_label.Text = "code in python file";
            this.codein_python_file_label.Click += new System.EventHandler(this.codein_python_file_label_Click);
            // 
            // imports_label
            // 
            this.imports_label.AutoSize = true;
            this.imports_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imports_label.ForeColor = System.Drawing.Color.White;
            this.imports_label.Location = new System.Drawing.Point(1190, 26);
            this.imports_label.Name = "imports_label";
            this.imports_label.Size = new System.Drawing.Size(130, 30);
            this.imports_label.TabIndex = 24;
            this.imports_label.Text = "Use imports";
            this.imports_label.Click += new System.EventHandler(this.imports_label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1190, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "--------------";
            // 
            // imports_button
            // 
            this.imports_button.BackColor = System.Drawing.Color.Black;
            this.imports_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imports_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imports_button.Location = new System.Drawing.Point(1195, 185);
            this.imports_button.Name = "imports_button";
            this.imports_button.Size = new System.Drawing.Size(105, 43);
            this.imports_button.TabIndex = 26;
            this.imports_button.Text = "Submit";
            this.imports_button.UseVisualStyleBackColor = false;
            this.imports_button.Click += new System.EventHandler(this.imports_button_Click);
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.help_label.ForeColor = System.Drawing.Color.White;
            this.help_label.Location = new System.Drawing.Point(12, 9);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(157, 30);
            this.help_label.TabIndex = 27;
            this.help_label.Text = "Help - Click me";
            this.help_label.Click += new System.EventHandler(this.help_label_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(968, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "--------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(532, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "Create class";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(532, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "--------------";
            // 
            // class_name_label
            // 
            this.class_name_label.AutoSize = true;
            this.class_name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_label.ForeColor = System.Drawing.Color.White;
            this.class_name_label.Location = new System.Drawing.Point(538, 117);
            this.class_name_label.Name = "class_name_label";
            this.class_name_label.Size = new System.Drawing.Size(119, 30);
            this.class_name_label.TabIndex = 31;
            this.class_name_label.Text = "Class name";
            this.class_name_label.Click += new System.EventHandler(this.class_name_label_Click);
            // 
            // classname_textbox
            // 
            this.classname_textbox.BackColor = System.Drawing.Color.Black;
            this.classname_textbox.ForeColor = System.Drawing.Color.White;
            this.classname_textbox.Location = new System.Drawing.Point(537, 161);
            this.classname_textbox.Name = "classname_textbox";
            this.classname_textbox.Size = new System.Drawing.Size(120, 20);
            this.classname_textbox.TabIndex = 32;
            this.classname_textbox.TextChanged += new System.EventHandler(this.classname_textbox_TextChanged);
            // 
            // submit_button_createclass
            // 
            this.submit_button_createclass.BackColor = System.Drawing.Color.Black;
            this.submit_button_createclass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_button_createclass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button_createclass.Location = new System.Drawing.Point(543, 286);
            this.submit_button_createclass.Name = "submit_button_createclass";
            this.submit_button_createclass.Size = new System.Drawing.Size(105, 43);
            this.submit_button_createclass.TabIndex = 33;
            this.submit_button_createclass.Text = "Submit";
            this.submit_button_createclass.UseVisualStyleBackColor = false;
            this.submit_button_createclass.Click += new System.EventHandler(this.submit_button_createclass_Click);
            // 
            // preview_richbox
            // 
            this.preview_richbox.BackColor = System.Drawing.Color.Black;
            this.preview_richbox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.preview_richbox.ForeColor = System.Drawing.Color.White;
            this.preview_richbox.Location = new System.Drawing.Point(17, 61);
            this.preview_richbox.Name = "preview_richbox";
            this.preview_richbox.Size = new System.Drawing.Size(459, 294);
            this.preview_richbox.TabIndex = 34;
            this.preview_richbox.Text = "";
            // 
            // preview_button_createclass
            // 
            this.preview_button_createclass.BackColor = System.Drawing.Color.Black;
            this.preview_button_createclass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preview_button_createclass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_button_createclass.Location = new System.Drawing.Point(543, 213);
            this.preview_button_createclass.Name = "preview_button_createclass";
            this.preview_button_createclass.Size = new System.Drawing.Size(105, 43);
            this.preview_button_createclass.TabIndex = 35;
            this.preview_button_createclass.Text = "Preview";
            this.preview_button_createclass.UseVisualStyleBackColor = false;
            this.preview_button_createclass.Click += new System.EventHandler(this.preview_button_createclass_Click);
            // 
            // preview_button_createfunction
            // 
            this.preview_button_createfunction.BackColor = System.Drawing.Color.Black;
            this.preview_button_createfunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preview_button_createfunction.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_button_createfunction.Location = new System.Drawing.Point(742, 359);
            this.preview_button_createfunction.Name = "preview_button_createfunction";
            this.preview_button_createfunction.Size = new System.Drawing.Size(105, 43);
            this.preview_button_createfunction.TabIndex = 36;
            this.preview_button_createfunction.Text = "Preview";
            this.preview_button_createfunction.UseVisualStyleBackColor = false;
            this.preview_button_createfunction.Click += new System.EventHandler(this.preview_button_createfunction_Click);
            // 
            // preview_button_template
            // 
            this.preview_button_template.BackColor = System.Drawing.Color.Black;
            this.preview_button_template.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preview_button_template.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_button_template.Location = new System.Drawing.Point(973, 213);
            this.preview_button_template.Name = "preview_button_template";
            this.preview_button_template.Size = new System.Drawing.Size(105, 43);
            this.preview_button_template.TabIndex = 37;
            this.preview_button_template.Text = "Preview";
            this.preview_button_template.UseVisualStyleBackColor = false;
            this.preview_button_template.Click += new System.EventHandler(this.preview_button_template_Click);
            // 
            // preview_button_imports
            // 
            this.preview_button_imports.BackColor = System.Drawing.Color.Black;
            this.preview_button_imports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preview_button_imports.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_button_imports.Location = new System.Drawing.Point(1195, 117);
            this.preview_button_imports.Name = "preview_button_imports";
            this.preview_button_imports.Size = new System.Drawing.Size(105, 43);
            this.preview_button_imports.TabIndex = 38;
            this.preview_button_imports.Text = "Preview";
            this.preview_button_imports.UseVisualStyleBackColor = false;
            this.preview_button_imports.Click += new System.EventHandler(this.preview_button_imports_Click);
            // 
            // hide_preview_checkbox
            // 
            this.hide_preview_checkbox.AutoSize = true;
            this.hide_preview_checkbox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.hide_preview_checkbox.Location = new System.Drawing.Point(17, 368);
            this.hide_preview_checkbox.Name = "hide_preview_checkbox";
            this.hide_preview_checkbox.Size = new System.Drawing.Size(73, 34);
            this.hide_preview_checkbox.TabIndex = 39;
            this.hide_preview_checkbox.Text = "hide";
            this.hide_preview_checkbox.UseVisualStyleBackColor = true;
            this.hide_preview_checkbox.CheckedChanged += new System.EventHandler(this.hide_preview_checkbox_CheckedChanged);
            // 
            // class_run_button
            // 
            this.class_run_button.BackColor = System.Drawing.Color.Black;
            this.class_run_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.class_run_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_run_button.Location = new System.Drawing.Point(559, 348);
            this.class_run_button.Name = "class_run_button";
            this.class_run_button.Size = new System.Drawing.Size(67, 43);
            this.class_run_button.TabIndex = 40;
            this.class_run_button.Text = "Run";
            this.class_run_button.UseVisualStyleBackColor = false;
            this.class_run_button.Click += new System.EventHandler(this.class_run_button_Click);
            // 
            // run_button_function
            // 
            this.run_button_function.BackColor = System.Drawing.Color.Black;
            this.run_button_function.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.run_button_function.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button_function.Location = new System.Drawing.Point(759, 493);
            this.run_button_function.Name = "run_button_function";
            this.run_button_function.Size = new System.Drawing.Size(67, 43);
            this.run_button_function.TabIndex = 41;
            this.run_button_function.Text = "Run";
            this.run_button_function.UseVisualStyleBackColor = false;
            this.run_button_function.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.run_button_function);
            this.Controls.Add(this.class_run_button);
            this.Controls.Add(this.hide_preview_checkbox);
            this.Controls.Add(this.preview_button_imports);
            this.Controls.Add(this.preview_button_template);
            this.Controls.Add(this.preview_button_createfunction);
            this.Controls.Add(this.preview_button_createclass);
            this.Controls.Add(this.preview_richbox);
            this.Controls.Add(this.submit_button_createclass);
            this.Controls.Add(this.classname_textbox);
            this.Controls.Add(this.class_name_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.help_label);
            this.Controls.Add(this.imports_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imports_label);
            this.Controls.Add(this.codein_python_file_label);
            this.Controls.Add(this.readme_label);
            this.Controls.Add(this.file_path_directory_textbox);
            this.Controls.Add(this.submit_template_button);
            this.Controls.Add(this.code_in_python_file_label);
            this.Controls.Add(this.select_directory_button);
            this.Controls.Add(this.readme_file_checkbox);
            this.Controls.Add(this.template_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prints_textbox);
            this.Controls.Add(this.prints_checkbox);
            this.Controls.Add(this.parameter_textbox);
            this.Controls.Add(this.functionname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parameter_checkbox);
            this.Controls.Add(this.createfunction_label);
            this.Controls.Add(this.submit_button_pyfunction);
            this.Controls.Add(this.textbox_filedic);
            this.Controls.Add(this.selectfile_button);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button selectfile_button;
        private System.Windows.Forms.TextBox textbox_filedic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button submit_button_pyfunction;
        private System.Windows.Forms.Label createfunction_label;
        private System.Windows.Forms.CheckBox parameter_checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox functionname_textbox;
        private System.Windows.Forms.TextBox parameter_textbox;
        private System.Windows.Forms.CheckBox prints_checkbox;
        private System.Windows.Forms.TextBox prints_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label template_label;
        private System.Windows.Forms.CheckBox readme_file_checkbox;
        private System.Windows.Forms.Button select_directory_button;
        private System.Windows.Forms.CheckBox code_in_python_file_label;
        private System.Windows.Forms.Button submit_template_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox file_path_directory_textbox;
        private System.Windows.Forms.Label readme_label;
        private System.Windows.Forms.Label codein_python_file_label;
        private System.Windows.Forms.Label imports_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button imports_button;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label class_name_label;
        private System.Windows.Forms.TextBox classname_textbox;
        private System.Windows.Forms.Button submit_button_createclass;
        private System.Windows.Forms.RichTextBox preview_richbox;
        private System.Windows.Forms.Button preview_button_createclass;
        private System.Windows.Forms.Button preview_button_createfunction;
        private System.Windows.Forms.Button preview_button_template;
        private System.Windows.Forms.Button preview_button_imports;
        private System.Windows.Forms.CheckBox hide_preview_checkbox;
        private System.Windows.Forms.Button class_run_button;
        private System.Windows.Forms.Button run_button_function;
    }
}

