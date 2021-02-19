
namespace Cryptographer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(32, 28);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(124, 17);
            this.radioButtonEncrypt.TabIndex = 0;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Зашифровать файл";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(162, 28);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(130, 17);
            this.radioButtonDecrypt.TabIndex = 1;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Расшифровать файл";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(32, 84);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(260, 20);
            this.textBoxFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(32, 148);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(260, 20);
            this.textBoxKey.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(32, 194);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Выполнить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(217, 194);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 17);
            this.progressBar1.TabIndex = 8;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(162, 58);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(130, 23);
            this.buttonFile.TabIndex = 9;
            this.buttonFile.Text = "Добавить файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(114, 194);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(97, 23);
            this.buttonClean.TabIndex = 10;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 290);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.radioButtonDecrypt);
            this.Controls.Add(this.radioButtonEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonClean;
    }
}

