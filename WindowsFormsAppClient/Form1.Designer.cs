namespace WindowsFormsAppClient
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
            this.radio_view = new System.Windows.Forms.RadioButton();
            this.radio_add = new System.Windows.Forms.RadioButton();
            this.radio_remove = new System.Windows.Forms.RadioButton();
            this.radio_edit = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radio_find = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.region = new System.Windows.Forms.TextBox();
            this.kind = new System.Windows.Forms.TextBox();
            this.quant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // radio_view
            // 
            this.radio_view.Location = new System.Drawing.Point(265, 31);
            this.radio_view.Name = "radio_view";
            this.radio_view.Size = new System.Drawing.Size(104, 24);
            this.radio_view.TabIndex = 1;
            this.radio_view.TabStop = true;
            this.radio_view.Text = "Просмотреть";
            this.radio_view.UseVisualStyleBackColor = true;
            // 
            // radio_add
            // 
            this.radio_add.Location = new System.Drawing.Point(265, 61);
            this.radio_add.Name = "radio_add";
            this.radio_add.Size = new System.Drawing.Size(104, 24);
            this.radio_add.TabIndex = 2;
            this.radio_add.TabStop = true;
            this.radio_add.Text = "Добавить";
            this.radio_add.UseVisualStyleBackColor = true;
            // 
            // radio_remove
            // 
            this.radio_remove.Location = new System.Drawing.Point(265, 91);
            this.radio_remove.Name = "radio_remove";
            this.radio_remove.Size = new System.Drawing.Size(104, 24);
            this.radio_remove.TabIndex = 3;
            this.radio_remove.TabStop = true;
            this.radio_remove.Text = "Удалить";
            this.radio_remove.UseVisualStyleBackColor = true;
            // 
            // radio_edit
            // 
            this.radio_edit.Location = new System.Drawing.Point(265, 121);
            this.radio_edit.Name = "radio_edit";
            this.radio_edit.Size = new System.Drawing.Size(104, 24);
            this.radio_edit.TabIndex = 4;
            this.radio_edit.TabStop = true;
            this.radio_edit.Text = "Редактировать";
            this.radio_edit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(410, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 69);
            this.listBox1.TabIndex = 5;
            // 
            // radio_find
            // 
            this.radio_find.Location = new System.Drawing.Point(265, 151);
            this.radio_find.Name = "radio_find";
            this.radio_find.Size = new System.Drawing.Size(104, 24);
            this.radio_find.TabIndex = 6;
            this.radio_find.TabStop = true;
            this.radio_find.Text = "Найти";
            this.radio_find.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Послать на сервер";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(12, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Показывать статус";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // region
            // 
            this.region.AccessibleName = "region";
            this.region.Location = new System.Drawing.Point(491, 52);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(127, 20);
            this.region.TabIndex = 10;
            // 
            // kind
            // 
            this.kind.AccessibleName = "kind";
            this.kind.Location = new System.Drawing.Point(491, 95);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(127, 20);
            this.kind.TabIndex = 11;
            // 
            // quant
            // 
            this.quant.AccessibleName = "quant";
            this.quant.Location = new System.Drawing.Point(491, 135);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(127, 20);
            this.quant.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(436, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Район";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(436, 93);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дерево";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(410, 133);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Количество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 225);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 305);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.region);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_find);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radio_edit);
            this.Controls.Add(this.radio_remove);
            this.Controls.Add(this.radio_add);
            this.Controls.Add(this.radio_view);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.RadioButton radio_view;
        private System.Windows.Forms.RadioButton radio_add;
        private System.Windows.Forms.RadioButton radio_remove;
        private System.Windows.Forms.RadioButton radio_edit;
        private System.Windows.Forms.RadioButton radio_find;

        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.TextBox kind;

        private System.Windows.Forms.TextBox region;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}