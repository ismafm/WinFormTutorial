namespace WinFormTutorial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listPersonas = new ListBox();
            personAge = new TextBox();
            personName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ShowButtom = new Button();
            ErrorText = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(53, 201);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 0;
            button1.Text = "Guardar datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listPersonas
            // 
            listPersonas.FormattingEnabled = true;
            listPersonas.Location = new Point(503, 311);
            listPersonas.Name = "listPersonas";
            listPersonas.Size = new Size(177, 104);
            listPersonas.TabIndex = 1;
            // 
            // personAge
            // 
            personAge.Location = new Point(53, 101);
            personAge.Name = "personAge";
            personAge.Size = new Size(154, 27);
            personAge.TabIndex = 2;
            personAge.TextChanged += personAge_TextChanged;
            // 
            // personName
            // 
            personName.Location = new Point(53, 35);
            personName.Name = "personName";
            personName.Size = new Size(154, 27);
            personName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 78);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Edad";
            // 
            // ShowButtom
            // 
            ShowButtom.Location = new Point(503, 152);
            ShowButtom.Name = "ShowButtom";
            ShowButtom.Size = new Size(143, 29);
            ShowButtom.TabIndex = 6;
            ShowButtom.Text = "Mostrar datos";
            ShowButtom.UseVisualStyleBackColor = true;
            ShowButtom.Click += ShowButtom_Click;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(53, 131);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(0, 20);
            ErrorText.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorText);
            Controls.Add(ShowButtom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(personName);
            Controls.Add(personAge);
            Controls.Add(listPersonas);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listPersonas;
        private TextBox personAge;
        private TextBox personName;
        private Label label1;
        private Label label2;
        private Button ShowButtom;
        private Label ErrorText;
    }
}
